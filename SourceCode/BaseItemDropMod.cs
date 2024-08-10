using HarmonyLib;

namespace FasterFlyingGoldBags;

[HarmonyPatch(typeof(BaseItemDrop), "Update")]
internal static class BaseItemDrop_Update {
    internal static void Postfix(BaseItemDrop __instance, ref float ___m_collectLockTimer) {
        if (__instance is not CoinDrop) return;
        if (__instance.ForceMagnetizedAlways) return;
        ___m_collectLockTimer = 0f;
        __instance.ForceMagnetize(true);
    }
}
