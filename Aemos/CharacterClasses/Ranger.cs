﻿namespace Aemos.CharacterClasses
{
    public class Ranger : Spellcaster
    {
        public Ranger()
        {
            ClassName = "Ranger";
            MaxSpellCycle = 5;
            FirstDC = 1;
            KeyAttribute = "Wisdom";
            CombatantType = 1;
            SkillClassModifier = 4;
        }
    }
}
