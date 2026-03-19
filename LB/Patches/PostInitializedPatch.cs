using HarmonyLib;

namespace LB.Patches
{
    [HarmonyPatch(typeof(GorillaTagger), nameof(GorillaTagger.Start))]
    internal static class PostInitializedPatch
    {
        public static void Postfix() => Events.Instance.TriggerGameInitialized();
    }
}
