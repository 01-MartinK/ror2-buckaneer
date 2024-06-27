using RoR2;
using BuckaneerMod.Modules.Achievements;

namespace BuckaneerMod.Survivors.Buckaneer.Achievements
{
    //automatically creates language tokens "ACHIEVMENT_{identifier.ToUpper()}_NAME" and "ACHIEVMENT_{identifier.ToUpper()}_DESCRIPTION" 
    [RegisterAchievement(identifier, unlockableIdentifier, null, null)]
    public class BuckaneerMasteryAchievement : BaseMasteryAchievement
    {
        public const string identifier = BuckaneerSurvivor.BUCKANEER_PREFIX + "masteryAchievement";
        public const string unlockableIdentifier = BuckaneerSurvivor.BUCKANEER_PREFIX + "masteryUnlockable";

        public override string RequiredCharacterBody => BuckaneerSurvivor.instance.bodyName;

        //difficulty coeff 3 is monsoon. 3.5 is typhoon for grandmastery skins
        public override float RequiredDifficultyCoefficient => 3;
    }
}