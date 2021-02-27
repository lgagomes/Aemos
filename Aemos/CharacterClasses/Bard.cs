namespace Aemos.CharacterClasses
{
    public class Bard : KnowlerOfSpells
    {
        public Bard()
        {
            ClassName = "Bard";
            MaxSpellCycle = 7;
            FirstDC = 0;
            KeyAttribute = "Charisma";
            CombatantType = 2;
            SkillClassModifier = 6;
        }
    }
}
