
using System.Xml;
using Verse;
using System.Collections.Generic;

namespace ProgressionAttire
{
    public class OperationList
    {
        public List<PatchOperation> operations = new List<PatchOperation>();

        public void LoadDataFromXmlCustom(XmlNode xmlRoot)
        {
            foreach (XmlNode node in xmlRoot.ChildNodes)
            {
                if (node.NodeType != XmlNodeType.Element) continue; // skip comments/whitespace
                operations.Add(DirectXmlToObject.ObjectFromXml<PatchOperation>(node, false));
            }
        }
    }
}
