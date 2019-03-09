namespace Aemos.CharacterClasses
{
    public class Sorcerer : KnowlerOfSpells
    {
        public Sorcerer(string classname)
        {
            ClassName = classname;
            MaxSpellCycle = 10;
            FirstDC = 0;
            KeyAttribute = "Charisma";
            CombatantType = 3;
            SkillClassModifier = 2;
        }
    }
}
