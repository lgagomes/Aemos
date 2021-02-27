namespace Aemos.CharacterClasses
{
    public class Paladin : Spellcaster
    {
        public Paladin()
        {
            ClassName = "Paladin";
            MaxSpellCycle = 5;
            FirstDC = 1;
            KeyAttribute = "Charisma";
            CombatantType = 1;
            SkillClassModifier = 2;
        }
    }
}
