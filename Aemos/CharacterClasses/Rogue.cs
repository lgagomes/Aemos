namespace Aemos.CharacterClasses
{
    public class Rogue : BaseClass
    {
        public Rogue(string classname)
        {
            ClassName = classname;
            CombatantType = 2;
            SkillClassModifier = 8;
        }
    }
}
