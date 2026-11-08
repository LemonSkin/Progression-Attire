using System;
using System.Linq;
using System.Xml;
using Verse;
using System.Collections.Generic;

namespace ferny.ProgressionAttire
{
    public enum MergeCompare { Name, InnerText, Both }

    public class PatchOperationMerge : PatchOperation
    {
        public string xpath;
        public bool selectSingleNode = false;
        protected XmlContainer value;

        private XmlNode currentTarget;
        private XmlNode currentChild;

        private static readonly string[] ControlAttrs =
            { "Operation", "Compare", "CheckAttributes", "XPathLocal", "Condition" };

        private struct Opts
        {
            public MergeCompare compare;
            public bool checkAttributes;
            public string xpathLocal;
        }

        protected override bool ApplyWorker(XmlDocument xml)
        {
            try
            {
                if (xpath == null) { ProgressionAttire.Error("PatchOperationMerge: <xpath> is null"); return false; }
                if (value?.node == null) { ProgressionAttire.Error("PatchOperationMerge: <value> is null"); return false; }

                List<XmlNode> targets;
                if (selectSingleNode)
                {
                    XmlNode n = xml.SelectSingleNode(xpath);
                    targets = n == null ? [] : [n];
                }
                else
                {
                    targets = xml.SelectNodes(xpath).Cast<XmlNode>().ToList();
                }

                if (targets.Count == 0)
                {
                    ProgressionAttire.Error($"PatchOperationMerge: no nodes matched '{xpath}'");
                    return false;
                }

                foreach (XmlNode target in targets)
                    foreach (XmlNode child in value.node.ChildNodes)
                        if (!Merge(target, child)) return false;
                return true;
            }
            catch (Exception e)
            {
                string child = currentChild == null ? "(none)" : currentChild.Name;
                string op = currentChild?.Attributes?["Operation"]?.Value ?? "(default)";
                ProgressionAttire.Error(
                    $"PatchOperationMerge failed: {e}\n" +
                    $"  xpath: {xpath.Trim()}\n" +
                    $"  Patch file: {(string.IsNullOrEmpty(sourceFile) ? "(unknown)" : sourceFile)}\n" +
                    $"  Target node: {NodePath(currentTarget)}\n" +
                    $"  Node being merged: <{child}> Operation={op}\n");
                // ProgressionAttire.Error(
                //     $"PatchOperationMerge failed: {e}\n" +
                //     $"  xpath: {xpath.Trim()}"
                // );
                return false;
            }
        }

        private bool Merge(XmlNode parent, XmlNode child)
        {
            currentTarget = parent;
            currentChild = child;
            if (child.NodeType != XmlNodeType.Element) return true; // skip comments/text

            string cond = child.Attributes["Condition"]?.Value;
            if (cond != null)
            {
                if (!bool.TryParse(ResolveCondition(cond), out bool ok))
                {
                    ProgressionAttire.Error($"<{child.Name}> Condition is not a boolean: '{cond}'");
                    return true;
                }
                if (!ok) return true;
            }

            string op = child.Attributes["Operation"]?.Value;
            var o = new Opts
            {
                compare = ParseCompare(child),
                checkAttributes = bool.TryParse(child.Attributes["CheckAttributes"]?.Value, out bool ca) && ca,
                xpathLocal = child.Attributes["XPathLocal"]?.Value
            };

            XmlNode found;
            switch (op)
            {
                case "Add": // Always add the node
                    Add(parent, child); return true;
                case "Replace": // Replace the node, error if node not found
                    if (!Find(parent, child, o, out found)) return NoMatch(child, op);
                    Replace(parent, child, found); return true;
                case "Remove": // Remove the node, error if not found
                    if (!Find(parent, child, o, out found)) return NoMatch(child, op);
                    parent.RemoveChild(found); return true;
                case "AddOrReplace": // Add if not existing, otherwise replace
                    if (Find(parent, child, o, out found)) Replace(parent, child, found);
                    else Add(parent, child);
                    return true;
                case "SafeAdd": // Add only if not present
                    if (!Find(parent, child, o, out found)) Add(parent, child);
                    return true;
                case "SafeReplace": // Replace only if present
                    if (Find(parent, child, o, out found)) Replace(parent, child, found);
                    return true;
                case "SafeRemove": // Remove only if present
                    if (Find(parent, child, o, out found)) parent.RemoveChild(found);
                    return true;
                case null:
                case "Safe": // Add node if it doesn't exist and continue processing children, add/replace leaves if they do exist
                    bool isLeaf = !child.ChildNodes.Cast<XmlNode>().Any(n => n.NodeType == XmlNodeType.Element);
                    if (isLeaf)
                    {
                        if (Find(parent, child, o, out found)) Replace(parent, child, found);
                        else Add(parent, child);
                        return true;
                    }
                    if (!Find(parent, child, o, out found)) found = Add(parent, child, false);
                    return Recurse(found, child);
                default:
                    ProgressionAttire.Error($"<{child.Name}> invalid Operation '{op}'");
                    return false;
            }
        }

        private bool Recurse(XmlNode parent, XmlNode child)
        {
            if (!child.ChildNodes.Cast<XmlNode>().Any(n => n.NodeType == XmlNodeType.Element))
                return true;
            foreach (XmlNode c in child.ChildNodes)
                if (!Merge(parent, c)) return false;
            return true;
        }

        private static bool Find(XmlNode parent, XmlNode template, Opts o, out XmlNode found)
        {
            found = null;
            XmlNode t = o.xpathLocal == null ? template : template.SelectSingleNode(o.xpathLocal);
            if (t == null) return false;

            foreach (XmlNode c in parent.ChildNodes)
            {
                if (c.NodeType != XmlNodeType.Element) continue;
                XmlNode cc = o.xpathLocal == null ? c : c.SelectSingleNode(o.xpathLocal);
                if (cc == null) continue;

                bool nameOk = cc.Name == t.Name;
                bool textOk = cc.InnerText == t.InnerText;
                bool hit = o.compare == MergeCompare.Name ? nameOk
                         : o.compare == MergeCompare.InnerText ? textOk
                         : nameOk && textOk;
                if (!hit) continue;
                if (o.checkAttributes && !AttrsMatch(template, c)) continue;

                found = c;
                return true;
            }
            return false;
        }

        private static bool AttrsMatch(XmlNode template, XmlNode candidate)
        {
            var want = template.Attributes.Cast<XmlAttribute>()
                .Where(a => !ControlAttrs.Contains(a.Name)).ToList();
            if (want.Count != candidate.Attributes.Count) return false;
            return want.All(a => candidate.Attributes[a.Name]?.Value == a.Value);
        }

        private static XmlNode Add(XmlNode parent, XmlNode child, bool deep = true)
        {
            XmlNode n = parent.OwnerDocument.ImportNode(child, deep);
            Strip(n);
            parent.AppendChild(n);
            return n;
        }

        private static void Replace(XmlNode parent, XmlNode child, XmlNode target)
        {
            XmlNode n = parent.OwnerDocument.ImportNode(child, true);
            Strip(n);
            parent.InsertAfter(n, target);
            parent.RemoveChild(target);
        }

        private static void Strip(XmlNode n)
        {
            if (n.NodeType != XmlNodeType.Element) return;
            foreach (var a in ControlAttrs) n.Attributes.RemoveNamedItem(a);
            foreach (XmlNode c in n.ChildNodes) Strip(c);
        }

        private static MergeCompare ParseCompare(XmlNode n)
        {
            string s = n.Attributes["Compare"]?.Value;
            return s != null && Enum.TryParse(s, true, out MergeCompare c) ? c : MergeCompare.Name;
        }

        private static bool NoMatch(XmlNode child, string op)
        {
            ProgressionAttire.Error($"No matching node for <{child.Name}> with Operation={op}");
            return false;
        }

        // Condition="{key}" -> your own settings; plain "true"/"false" passes through.
        // Mod-active checks fit here too, e.g. "{mod:some.packageId}" -> ModsConfig.IsActive(...)
        private static string ResolveCondition(string raw)
        {
            raw = raw.Trim();
            if (raw.Length <= 2 || raw[0] != '{' || raw[^1] != '}')
                return raw; // plain "true"/"false" passes through

            string key = raw[1..^1].Trim();

            var settings = ProgressionAttire.Settings;
            if (settings == null)
            {
                ProgressionAttire.Error($"PatchOperationMerge: settings unavailable, treating '{key}' as false.");
                return "false";
            }

            bool? value = settings.GetBool(key);
            if (value == null)
            {
                ProgressionAttire.Error($"PatchOperationMerge: no bool setting named '{key}', treating as false.");
                return "false";
            }
            return value.Value.ToString();
        }

        private static string NodePath(XmlNode n)
        {
            var parts = new List<string>();
            for (; n != null && n.NodeType == XmlNodeType.Element; n = n.ParentNode)
                parts.Add(n.Name);
            parts.Reverse();
            return string.Join("/", parts);
        }

    }
}
