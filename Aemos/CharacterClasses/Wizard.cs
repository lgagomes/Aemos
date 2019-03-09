namespace Aemos.CharacterClasses
{
    public class Wizard : Spellcaster
    {
        public Wizard(string classname)
        {
            ClassName = classname;
            MaxSpellCycle = 10;
            FirstDC = 0;
            KeyAttribute = "Intelligence";
            CombatantType = 3;
            SkillClassModifier = 2;
        }
    }
}
