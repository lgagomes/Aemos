namespace Aemos.CharacterClasses
{
    public class Barbarian : BaseClass
    {
        public Barbarian(string classname)
        {
            ClassName = classname;
            CombatantType = 1;
            SkillClassModifier = 4;
        }
    }
}
