using BuckaneerMod.Survivors.Buckaneer.Achievements;
using RoR2;
using UnityEngine;

namespace BuckaneerMod.Survivors.Buckaneer
{
    public static class BuckaneerUnlockables
    {
        public static UnlockableDef characterUnlockableDef = null;
        public static UnlockableDef masterySkinUnlockableDef = null;

        public static void Init()
        {
            masterySkinUnlockableDef = Modules.Content.CreateAndAddUnlockbleDef(
                BuckaneerMasteryAchievement.unlockableIdentifier,
                Modules.Tokens.GetAchievementNameToken(BuckaneerMasteryAchievement.identifier),
                BuckaneerSurvivor.instance.assetBundle.LoadAsset<Sprite>("texMasteryAchievement"));
        }
    }
}
