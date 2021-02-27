namespace Aemos.CharacterClasses
{
    public class Sorcerer : KnowlerOfSpells
    {
        public Sorcerer()
        {
            ClassName = "Sorcerer";
            MaxSpellCycle = 10;
            FirstDC = 0;
            KeyAttribute = "Charisma";
            CombatantType = 3;
            SkillClassModifier = 2;
        }
    }
}
