using System.Xml;
using Verse;

namespace ferny.ProgressionAttire
{

    public class PatchOperationCheckSetting : PatchOperation
    {
        public string settingName;
        public OperationList caseTrue;
        public OperationList caseFalse;


        protected override bool ApplyWorker(XmlDocument xml)
        {
            ProgressionAttireSettings settings = ProgressionAttire.Settings;

            if (settings == null)
            {
                ProgressionAttire.Error("PatchOperationCheckSetting: Could not load mod settings.");
                return false;
            }

            bool settingValue;
            switch (settingName)
            {
                case "applyRebalances": settingValue = settings.applyRebalances; break;
                case "applyCategories": settingValue = settings.applyCategories; break;
                default:
                    ProgressionAttire.Error($"PatchOperationCheckSetting: Unknown settingName '{settingName}'.");
                    return false;
            }

            var ops = (settingValue ? caseTrue : caseFalse)?.operations;
            if (ops == null) return true;

            foreach (var op in ops)
            {
                if (!op.Apply(xml))
                {
                    ProgressionAttire.Error($"PatchOperationCheckSetting: operation failed: {op}");
                    // return false;
                    // Keep processing others, one failure shouldn't halt progress matey
                }
            }
            return true;
        }
    }
}
