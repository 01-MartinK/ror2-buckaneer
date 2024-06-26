﻿using BuckaneerMod.Survivors.Buckaneer.SkillStates;

namespace BuckaneerMod.Survivors.Buckaneer
{
    public static class BuckaneerStates
    {
        public static void Init()
        {
            Modules.Content.AddEntityState(typeof(SlashCombo));

            Modules.Content.AddEntityState(typeof(Shoot));

            Modules.Content.AddEntityState(typeof(Roll));

            Modules.Content.AddEntityState(typeof(ThrowBomb));
        }
    }
}
