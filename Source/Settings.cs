using Verse;
using HarmonyLib;

namespace ferny.ProgressionAttire
{
    public class ProgressionAttireSettings : ModSettings
    {
        public bool applyCategories = true;
        public bool applyRebalances = true;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref applyCategories, "applyCategories", true);
            Scribe_Values.Look(ref applyRebalances, "applyRebalances", true);
            base.ExposeData();
        }

        public bool? GetBool(string key) => key switch
        {
            nameof(applyCategories) => applyCategories,
            nameof(applyRebalances) => applyRebalances,
            _ => null
        };
    }
}
