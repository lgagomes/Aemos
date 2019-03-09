namespace Aemos.CharacterClasses
{
    public class Cleric : Spellcaster
    {
        public Cleric(string classname)
        {
            ClassName = classname;
            MaxSpellCycle = 10;
            FirstDC = 0;
            KeyAttribute = "Wisdom";
            CombatantType = 2;
            SkillClassModifier = 2;
        }
    }
}
