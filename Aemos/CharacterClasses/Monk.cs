using System;

namespace Aemos.CharacterClasses
{
    public class Monk : BaseClass
    {
        public double[] FuryOfBlowsBonus;

        public Monk()
        {
            ClassName = "Monk";
            CombatantType = 2;
            FuryOfBlowsBonus = new double[5];
            SkillClassModifier = 4;
        }

        public void CalculateFuryOfBlowsBonus()
        {
            if (CharacterLevel < 11)
            {
                FuryOfBlowsBonus[0] = CharacterLevel - 3;
                FuryOfBlowsBonus[1] = CharacterLevel - 3;
                FuryOfBlowsBonus[2] = FuryOfBlowsBonus[1] - 5;
                FuryOfBlowsBonus[3] = 0;
                FuryOfBlowsBonus[4] = 0;
            }
            else
            {
                FuryOfBlowsBonus[0] = Math.Floor(CharacterLevel * 0.75);
                FuryOfBlowsBonus[1] = Math.Floor(CharacterLevel * 0.75);
                FuryOfBlowsBonus[2] = FuryOfBlowsBonus[1];
                FuryOfBlowsBonus[3] = FuryOfBlowsBonus[2] - 5;
                FuryOfBlowsBonus[4] = FuryOfBlowsBonus[3] - 5;
            }
        }
    }
}
