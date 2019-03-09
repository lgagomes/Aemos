using Aemos.Helpers;
using System;

namespace Aemos.CharacterClasses
{
    public class BaseClass
    {
        public string ClassName { get; set; }
        public int CharacterLevel { get; set; }
        public int Charisma { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public double[] BaseAttackBonus { get; set; }
        public int CombatantType { get; set; }
        public int SkillClassModifier { get; set; } // how much each class adds to skill points calculations
        public SkillPointsCalculator SkillPointsCalculator;
        private double _progression;     // defines the progression growth of the 1st attack
        private int[] _attackThresholds;                                 

        /*
         * Combatant types:
         *  1 = Full combatants: barbarians, warriors, paladins, rangers
         *  2 = Semi-combatants: bards, clerics, druids, rogues, monks
         *  3 = Non-combatants: sorcerers, wizards         * 
         */

        public BaseClass()
        {
            BaseAttackBonus = new double[4];
        }

        public void CalculateBaseAttackBonus()
        {
            SetProgressionAndThreshold();

            BaseAttackBonus[0] = Math.Floor(CharacterLevel * _progression);

            for (int i = 0; i < _attackThresholds.Length; i++)
            {
                BaseAttackBonus[i + 1] = (CharacterLevel - _attackThresholds[i] > 0)
                    ? BaseAttackBonus[i + 1] = BaseAttackBonus[i] - 5
                    : BaseAttackBonus[i + 1] = 0;
            }
        }

        private void SetProgressionAndThreshold()
        {
            /*  attackThresholds[0] defines when the class gains the 2nd extra attack
                attackThresholds[1] defines when the class gains the 3rd extra attack (if available)
                attackThresholds[2] defines when the class gains the 4th extra attack (if available) */

            switch (CombatantType)
            {
                case 1:
                    _progression = 1;
                    _attackThresholds = new int[] { 5, 10, 15 };
                    break;

                case 2:
                    _progression = 0.75;
                    _attackThresholds = new int[] { 8, 14, 20 };
                    break;

                case 3:
                    _progression = 0.5;
                    _attackThresholds = new int[] { 11, 20, 20 };
                    break;

                default:
                    _progression = 0;
                    _attackThresholds = new int[] { 0, 0, 0 };
                    break;
            }
        }

        public int GetModifier(int attributeScore)
        {
            return (attributeScore > 0)
                ? (attributeScore - 10) / 2
                : 0;
        }

        public void UpdateSkillPointsModifiers()
        {
            SkillPointsCalculator.IntelligenceBonuses.IntBonus4thLevelValue = GetModifier(Intelligence + 1);
            SkillPointsCalculator.IntelligenceBonuses.IntBonus8thLevelValue = GetModifier(Intelligence + 2);
            SkillPointsCalculator.IntelligenceBonuses.IntBonus12thLevelValue = GetModifier(Intelligence + 3);
            SkillPointsCalculator.IntelligenceBonuses.IntBonus16thLevelValue = GetModifier(Intelligence + 4);
            SkillPointsCalculator.IntelligenceBonuses.IntBonus20thLevelValue = GetModifier(Intelligence + 5);
        }
    }
}
