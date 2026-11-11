using Verse;
using HarmonyLib;

namespace ProgressionAttire
{
    public class ProgressionAttireSettings : ModSettings
    {
        public bool applyCategories = true;
        public bool applyRebalances = true;
        public bool createStyles = true;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref applyCategories, "applyCategories", true);
            Scribe_Values.Look(ref applyRebalances, "applyRebalances", true);
            Scribe_Values.Look(ref applyRebalances, "createStyles", true);
            base.ExposeData();
        }

        public bool? GetBool(string key) => key switch
        {
            nameof(applyCategories) => applyCategories,
            nameof(applyRebalances) => applyRebalances,
            nameof(createStyles) => createStyles,
            _ => null
        };
    }
}
