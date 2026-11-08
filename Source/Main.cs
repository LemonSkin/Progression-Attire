using HarmonyLib;
using UnityEngine;
using Verse;

namespace ferny.ProgressionAttire
{
    public class ProgressionAttire : Mod
    {
        public static ProgressionAttireSettings Settings { get; private set; }

        public ProgressionAttire(ModContentPack content) : base(content)
        {
            Settings = GetSettings<ProgressionAttireSettings>();
            // Harmony harmony = new("ferny.progressionattire");
            // harmony.PatchAll();
            new Harmony("ferny.progressionattire").PatchAll();
        }

        public override string SettingsCategory() => "Progression: Attire";

        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listing = new();
            listing.Begin(inRect);
            listing.CheckboxLabeled("Apply Categories", ref Settings.applyCategories);
            listing.CheckboxLabeled("Apply Rebalances", ref Settings.applyRebalances);
            listing.End();
        }

        public static void Log(string message)
        {
            Verse.Log.Message($"[Progression: Attire] {message}");
        }

        public static void Warning(string message)
        {
            Verse.Log.Warning($"[Progression: Attire] {message}");
        }

        public static void Error(string message)
        {
            Verse.Log.Error($"[Progression: Attire] {message}");
        }
    }
}
