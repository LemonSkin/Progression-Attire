using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using UnityEngine;
using Verse;
using Verse.AI;
using Verse.AI.Group;
using Verse.Sound;
using Verse.Noise;
using Verse.Grammar;
using RimWorld;
using RimWorld.Planet;

namespace ProgressionAttire
{
    internal static class Costume
    {
        static readonly List<StatModifier> dressStats = new List<StatModifier> {
                    new StatModifier { stat = StatDefOf.MaxHitPoints, value = 100f },
                    new StatModifier { stat = StatDefOf.WorkToMake, value = 3200f },
                    new StatModifier { stat = StatDefOf.Mass, value = 0.75f },
                    new StatModifier { stat = StatDefOf.EquipDelay, value = 3.5f},
                    new StatModifier { stat = StatDefOf.StuffEffectMultiplierArmor, value = 0.05f },
                    new StatModifier { stat = StatDefOf.StuffEffectMultiplierInsulation_Cold, value = 0.44f },
                    new StatModifier { stat = StatDefOf.StuffEffectMultiplierInsulation_Heat, value = 0.18f },
                    new StatModifier { stat = StatDefOf.Flammability, value = 1.0f },
                    new StatModifier { stat = StatDefOf.DeteriorationRate, value = 2.0f },
                    new StatModifier { stat = StatDefOf.Beauty, value = 0.0f },
                    new StatModifier { stat = StatDefOf.SellPriceFactor, value = 0.25f }
                    };
        static readonly List<StatModifier> shirtStats = new List<StatModifier> {
                    new StatModifier { stat = StatDefOf.MaxHitPoints, value = 100f },
                    new StatModifier { stat = StatDefOf.WorkToMake, value = 1600f },
                    new StatModifier { stat = StatDefOf.Mass, value = 0.25f },
                    new StatModifier { stat = StatDefOf.EquipDelay, value = 1.5f},
                    new StatModifier { stat = StatDefOf.StuffEffectMultiplierArmor, value = 0.05f },
                    new StatModifier { stat = StatDefOf.StuffEffectMultiplierInsulation_Cold, value = 0.22f },
                    new StatModifier { stat = StatDefOf.StuffEffectMultiplierInsulation_Heat, value = 0.1f },
                    new StatModifier { stat = StatDefOf.Flammability, value = 1.0f },
                    new StatModifier { stat = StatDefOf.DeteriorationRate, value = 2.0f },
                    new StatModifier { stat = StatDefOf.Beauty, value = 0.0f },
                    new StatModifier { stat = StatDefOf.SellPriceFactor, value = 0.25f }
                    };
        static readonly List<StatModifier> pantsStats = new List<StatModifier> {
                    new StatModifier { stat = StatDefOf.MaxHitPoints, value = 100f },
                    new StatModifier { stat = StatDefOf.WorkToMake, value = 1600f },
                    new StatModifier { stat = StatDefOf.Mass, value = 0.5f },
                    new StatModifier { stat = StatDefOf.EquipDelay, value = 2.0f},
                    new StatModifier { stat = StatDefOf.StuffEffectMultiplierArmor, value = 0.05f },
                    new StatModifier { stat = StatDefOf.StuffEffectMultiplierInsulation_Cold, value = 0.2f },
                    new StatModifier { stat = StatDefOf.StuffEffectMultiplierInsulation_Heat, value = 0.08f },
                    new StatModifier { stat = StatDefOf.Flammability, value = 1.0f },
                    new StatModifier { stat = StatDefOf.DeteriorationRate, value = 2.0f },
                    new StatModifier { stat = StatDefOf.Beauty, value = 0.0f },
                    new StatModifier { stat = StatDefOf.SellPriceFactor, value = 0.25f }
                    };
        static readonly List<StatModifier> headgearStats = new List<StatModifier> {
                    new StatModifier { stat = StatDefOf.MaxHitPoints, value = 80f },
                    new StatModifier { stat = StatDefOf.WorkToMake, value = 1200f },
                    new StatModifier { stat = StatDefOf.Mass, value = 0.07f },
                    new StatModifier { stat = StatDefOf.EquipDelay, value = 0.8f },
                    new StatModifier { stat = StatDefOf.StuffEffectMultiplierArmor, value = 0.0f },
                    new StatModifier { stat = StatDefOf.StuffEffectMultiplierInsulation_Cold, value = 0.1f },
                    new StatModifier { stat = StatDefOf.StuffEffectMultiplierInsulation_Heat, value = 0.1f },
                    new StatModifier { stat = StatDefOf.Flammability, value = 1.0f },
                    new StatModifier { stat = StatDefOf.DeteriorationRate, value = 2.0f },
                    new StatModifier { stat = StatDefOf.Beauty, value = 0.0f },
                    new StatModifier { stat = StatDefOf.SellPriceFactor, value = 0.25f }
                    };
        public static int PatchApparel(ThingDef thingDef)
        {
            if (thingDef.apparel.bodyPartGroups.Contains(BodyPartGroupDefOf.Torso) && thingDef.apparel.bodyPartGroups.Contains(BodyPartGroupDefOf.Legs))
            {
                return ApplyPatch(thingDef, dressStats, "LemonSkin_Costume");
            }
            else if (thingDef.apparel.bodyPartGroups.Contains(BodyPartGroupDefOf.Torso))
            {
                return ApplyPatch(thingDef, shirtStats, "LemonSkin_Costume");
            }
            else if (thingDef.apparel.bodyPartGroups.Contains(BodyPartGroupDefOf.Legs))
            {
                return ApplyPatch(thingDef, pantsStats, "LemonSkin_Costume");
            }
            else if (thingDef.apparel.bodyPartGroups.Contains(BodyPartGroupDefOf.FullHead) || thingDef.apparel.bodyPartGroups.Contains(BodyPartGroupDefOf.UpperHead))
            {
                return ApplyPatch(thingDef, headgearStats, "LemonSkin_CostumeHeadgear");
            }
            else
            {
                return ApplyPatch(thingDef, headgearStats, "LemonSkin_Costume");
            }
        }

        public static int ApplyPatch(ThingDef thingDef, List<StatModifier> stats, string category)
        {
            Utils.ApplyCategory(thingDef, category);
            thingDef.apparel.tags = new List<string>();
            thingDef.apparel.defaultOutfitTags = new List<string>();
            thingDef.tradeability = Tradeability.None;
            thingDef.equippedStatOffsets = new List<StatModifier>();
            thingDef.statBases = new List<StatModifier>(stats);
            return 1;
        }

    }


}
