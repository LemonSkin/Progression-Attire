using System.Xml;
using Verse;

namespace ProgressionAttire
{

    public class PatchOperationCheckSetting : PatchOperation
    {
        public string settingName;
        public OperationList caseTrue;
        public OperationList caseFalse;
        public bool stopOnFailure = false;

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
                case "createStyles": settingValue = settings.createStyles; break;
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
                    if (stopOnFailure) return false;
                }
            }
            return true;
        }
    }
}
