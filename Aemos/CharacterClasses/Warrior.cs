namespace Aemos.CharacterClasses
{
    public class Warrior : BaseClass
    {
        public Warrior(string classname)
        {
            ClassName = classname;
            CombatantType = 1;
            SkillClassModifier = 2;
        }
    }
}
