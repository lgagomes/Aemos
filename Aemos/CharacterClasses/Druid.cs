namespace Aemos.CharacterClasses
{
    public class Druid : Spellcaster
    {
        public Druid(string classname)
        {
            ClassName = classname;
            MaxSpellCycle = 10;
            FirstDC = 0;
            KeyAttribute = "Wisdom";
            CombatantType = 2;
            SkillClassModifier = 4;
        }
    }
}
