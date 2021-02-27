namespace Aemos.CharacterClasses
{
    public class Wizard : Spellcaster
    {
        public Wizard()
        {
            ClassName = "Wizard";
            MaxSpellCycle = 10;
            FirstDC = 0;
            KeyAttribute = "Intelligence";
            CombatantType = 3;
            SkillClassModifier = 2;
        }
    }
}
