namespace Aemos.CharacterClasses
{
    public class Paladin : Spellcaster
    {
        public Paladin(string classname)
        {
            ClassName = classname;
            MaxSpellCycle = 5;
            FirstDC = 1;
            KeyAttribute = "Charisma";
            CombatantType = 1;
            SkillClassModifier = 2;
        }
    }
}
