using RimWorld;
using Verse;
using HarmonyLib;
// using XmlExtensions;

namespace ProgressionAttire
{
    [HarmonyPatch(typeof(DefGenerator), nameof(DefGenerator.GenerateImpliedDefs_PreResolve))]
    public static class DefGenerator_PreResolve_Patch
    {
        public static bool Prefix()
        {
            ProgressionAttireSettings settings = ProgressionAttire.Settings;

            if (settings == null)
            {
                ProgressionAttire.Error("DefGenerator_PreResolve_Patch: Could not load settings, skipping patch.");
                return true;
            }

            bool applyCategories = settings?.applyCategories ?? false;
            int vanityItemsPatched = 0;
            int costumeItemsPatched = 0;
            foreach (ThingDef thingDef in DefDatabase<ThingDef>.AllDefs)
            {
                if (thingDef.recipeMaker?.researchPrerequisite?.Equals(DefDatabase<ResearchProjectDef>.GetNamed("Ferny_VanityTable", false)) == true)
                {
                    vanityItemsPatched += PatchVanity(thingDef, applyCategories);
                }
                else if (thingDef.recipeMaker?.researchPrerequisite?.Equals(DefDatabase<ResearchProjectDef>.GetNamed("Ferny_CostumingTable", false)) == true)
                {
                    costumeItemsPatched += PatchCostume(thingDef, applyCategories);
                }
            }
            ProgressionAttire.Log($"Patched {vanityItemsPatched} vanity items & {costumeItemsPatched} costume items");
            return true;
        }


        private static int PatchVanity(ThingDef thingDef, bool applyCategories)
        {
            if (applyCategories == true)
            {
                if (thingDef.apparel.bodyPartGroups.ContainsAny(g => g == BodyPartGroupDefOf.FullHead || g == BodyPartGroupDefOf.UpperHead))
                {
                    thingDef.thingCategories = [DefDatabase<ThingCategoryDef>.GetNamed("LemonSkin_VanityHeadgear", false)];
                }
                else
                {
                    thingDef.thingCategories = [DefDatabase<ThingCategoryDef>.GetNamed("LemonSkin_VanityApparel", false)];
                }
            }

            CleanThing(thingDef);
            thingDef.recipeMaker.recipeUsers = [DefDatabase<ThingDef>.GetNamed("Ferny_VanityTable", false)];

            return 1;
        }

        private static int PatchCostume(ThingDef thingDef, bool applyCategories)
        {
            if (applyCategories == true)
            {
                if (thingDef.apparel.bodyPartGroups.ContainsAny(g => g == BodyPartGroupDefOf.FullHead || g == BodyPartGroupDefOf.UpperHead))
                {
                    thingDef.thingCategories = [DefDatabase<ThingCategoryDef>.GetNamed("LemonSkin_CostumeHeadgear", false)];
                }
                else
                {
                    thingDef.thingCategories = [DefDatabase<ThingCategoryDef>.GetNamed("LemonSkin_Costume", false)];
                }
            }

            thingDef.recipeMaker.recipeUsers = [DefDatabase<ThingDef>.GetNamed("Ferny_CostumingTable", false)];
            CleanThing(thingDef);

            return 1;
        }

        private static void CleanThing(ThingDef thingDef) {
            thingDef.recipeMaker.skillRequirements = [];
            thingDef.apparel.tags = [];
            thingDef.apparel.defaultOutfitTags = [];
            thingDef.tradeability = Tradeability.None;
            thingDef.tradeTags = [];
        }
    }


}
