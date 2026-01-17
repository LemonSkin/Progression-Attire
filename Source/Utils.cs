using System.Collections.Generic;

using Verse;

namespace ProgressionAttire
{
    internal static class Utils
    {
        private static readonly HashSet<ThingCategoryDef> modifiedCategories = new HashSet<ThingCategoryDef>();
        public static void ApplyCategory(ThingDef thingDef, string Category)
        {
            ThingCategoryDef apparelCategory = DefDatabase<ThingCategoryDef>.GetNamed(Category);
            if (thingDef.thingCategories != null)
            {
                List<ThingCategoryDef> oldCategories = new List<ThingCategoryDef>(thingDef.thingCategories);
                foreach (ThingCategoryDef oldCat in oldCategories)
                {
                    oldCat.childThingDefs?.Remove(thingDef);
                    thingDef.thingCategories.Remove(oldCat);
                    modifiedCategories.Add(oldCat);
                }
            }
            else
            {
                thingDef.thingCategories = new List<ThingCategoryDef>();
            }

            thingDef.thingCategories.Add(apparelCategory);
            apparelCategory.childThingDefs.Add(thingDef);
            modifiedCategories.Add(apparelCategory);
        }

        public static void RefreshModifiedCategories()
        {
            foreach (ThingCategoryDef category in modifiedCategories)
            {
                category.ClearCachedData();
                category.ResolveReferences();
            }
            modifiedCategories.Clear();
        }
    }

}