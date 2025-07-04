using HarmonyLib;

namespace REPOTeamBoosters.Patches
{
    [HarmonyPatch(typeof(ItemUpgradePlayerCrouchRest), nameof(ItemUpgradePlayerCrouchRest.Upgrade))]
    internal class ItemUpgradePlayerCrouchRestPatch
    {
        static bool Prefix(ItemUpgradePlayerCrouchRest __instance)
        {
            var players = SemiFunc.PlayerGetAll();

            foreach (var player in players)
            {
                PunManager.instance.UpgradePlayerCrouchRest(SemiFunc.PlayerGetSteamID(player));
            }

            return false;
        }
    }
}
