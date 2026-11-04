using Verse;
using HarmonyLib;

namespace ferny.ProgressionAttire
{
    public class ProgressionAttire : Mod
    {
        public ProgressionAttire(ModContentPack content) : base(content)
        {
            var harmony = new Harmony("ferny.progressionattire");
            harmony.PatchAll();
        }

        public static void Log(string message)
        {
            Verse.Log.Message($"[Progression: Attire] {message}");
        }

        public static void Warning(string message)
        {
            Verse.Log.Warning($"[Progression: Attire] {message}");
        }
    }
}
