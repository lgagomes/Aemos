namespace Aemos.CharacterClasses
{
    public class Bard : KnowlerOfSpells
    {
        public Bard(string classname)
        {
            ClassName = classname;
            MaxSpellCycle = 7;
            FirstDC = 0;
            KeyAttribute = "Charisma";
            CombatantType = 2;
            SkillClassModifier = 6;
        }
    }
}
