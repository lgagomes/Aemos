namespace Aemos.CharacterClasses
{
    public class Druid : Spellcaster
    {
        public Druid()
        {
            ClassName = "Druid";
            MaxSpellCycle = 10;
            FirstDC = 0;
            KeyAttribute = "Wisdom";
            CombatantType = 2;
            SkillClassModifier = 4;
        }
    }
}
