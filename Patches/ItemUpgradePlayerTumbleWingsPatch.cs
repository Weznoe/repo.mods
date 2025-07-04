using HarmonyLib;

namespace REPOTeamBoosters.Patches
{
    [HarmonyPatch(typeof(ItemUpgradePlayerTumbleWings), nameof(ItemUpgradePlayerTumbleWings.Upgrade))]
    internal class ItemUpgradePlayerTumbleWingsPatch
    {
        static bool Prefix(ItemUpgradePlayerTumbleWings __instance)
        {
            var players = SemiFunc.PlayerGetAll();

            foreach (var player in players)
            {
                PunManager.instance.UpgradePlayerTumbleWings(SemiFunc.PlayerGetSteamID(player));
            }

            return false;
        }
    }
}
