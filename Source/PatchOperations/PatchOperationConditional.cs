using System;
using System.Collections.Generic;
using System.Xml;
using Verse;

namespace ProgressionAttire
{
    public class PatchOperationConditional : PatchOperation
    {
        public string xpath;
        public OperationList caseTrue;
        public OperationList caseFalse;
        public bool stopOnFailure = false;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (string.IsNullOrWhiteSpace(xpath))
            {
                ProgressionAttire.Error($"{GetType().Name}: <xpath> is null ({sourceFile ?? "nested"})");
                return false;
            }

            try
            {
                bool exists = xml.SelectSingleNode(xpath.Trim()) != null;
                List<PatchOperation> ops = (exists ? caseTrue : caseFalse)?.operations;
                if (ops == null) return true;

                for (int i = 0; i < ops.Count; i++)
                {
                    PatchOperation op = ops[i];
                    op.sourceFile ??= sourceFile;

                    if (!op.Apply(xml))
                    {
                        ProgressionAttire.Error(
                            $"{GetType().Name}: operation {i + 1} ({op.GetType().Name}) failed\n" +
                            $"  file: {sourceFile ?? "(nested)"}\n" +
                            $"  xpath: {xpath.Trim()} (matched: {exists})");
                        if (stopOnFailure) return false;
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                ProgressionAttire.Error($"{GetType().Name} failed: {e}\n  xpath: {xpath}");
                return !stopOnFailure;
            }
        }
    }
}
