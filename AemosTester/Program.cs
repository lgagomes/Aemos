using Aemos.CharacterClasses;
using Aemos.Helpers;
using System;
using System.Data;
using System.Xml;

namespace AemosTester
{
    class Program
    {
        private const int SPELLS = 0;
        private const int LOAD = 1;
        private const int BASE_ATTACK_BONUS = 2;
        private const int FURY_OF_BLOWS = 3;
        private const int SKILL_POINTS = 4;
        private const int DICE_ROLL = 5;

        static void Main(string[] args)
        {
            int testToExecute = SPELLS;

            switch(testToExecute)
            {
                case LOAD: TestLoad(); break;
                case BASE_ATTACK_BONUS: TestBaseAttackBonus();break;
                case FURY_OF_BLOWS: TestMonkFoBAttackBonus(); break;
                case SKILL_POINTS: TestSkillPointsCalculation(); break; 
                case DICE_ROLL: TestDiceRoll(); break;
                default: break;
            }
            Console.Read();
        }

        private static void TestLoad()
        {
            LoadCalculator load = new LoadCalculator();
            int str = 9;

            load.CalculateLoad(str, 4, false);
            Console.WriteLine("STR = " + str);
            Console.WriteLine("\t\t  |lbs.\t\t |kgs");
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Light Load   \t  |up to " + load.LoadsLbs[0] + "\t |up to " + load.LoadsKgs[0]);
            Console.WriteLine("Medium Load   \t  |" + load.LoadsLbs[1] + " to " + load.LoadsLbs[2] + "\t |" + load.LoadsKgs[1] + " to " + load.LoadsKgs[2]);
            Console.WriteLine("Heavy Load   \t  |" + load.LoadsLbs[3] + " to " + load.LoadsLbs[4] + "\t |" + load.LoadsKgs[3] + " to " + load.LoadsKgs[4]);
            Console.WriteLine("Lift over head    |" + load.LoadsLbs[5] + "\t\t |" + load.LoadsKgs[5]);
            Console.WriteLine("Lift off ground   |" + load.LoadsLbs[6] + "\t\t |" + load.LoadsKgs[6]);
            Console.WriteLine("Push or drag   \t  |" + load.LoadsLbs[7] + "\t\t |" + load.LoadsKgs[7]);
        }

        private static void TestBaseAttackBonus()
        {
            Paladin paladin = new Paladin("paladin");
            paladin.CharacterLevel = 7;
            paladin.CalculateBaseAttackBonus();

            Console.WriteLine(paladin.BaseAttackBonus[0] + " / " +
                paladin.BaseAttackBonus[1] + " / " +
                paladin.BaseAttackBonus[2] + " / " +
                paladin.BaseAttackBonus[3]);
        }

        private static void TestMonkFoBAttackBonus() // FoB = Fury of Blows
        {
            Monk monk = new Monk("monk");
            monk.CharacterLevel = 16;
            monk.CalculateFuryOfBlowsBonus();
            Console.WriteLine(monk.FuryOfBlowsBonus[0] + " / " +
                monk.FuryOfBlowsBonus[1] + " / " +
                monk.FuryOfBlowsBonus[2] + " / " +
                monk.FuryOfBlowsBonus[3] + " / " +
                monk.FuryOfBlowsBonus[4]);
        }

        private static void TestSkillPointsCalculation()
        {
            Barbarian barbarian = new Barbarian("barbarian");
            barbarian.SkillPointsCalculator = new SkillPointsCalculator();
            barbarian.CharacterLevel = 9;
            barbarian.Intelligence = 1;
            barbarian.UpdateSkillPointsModifiers();
            barbarian.SkillPointsCalculator.IntelligenceBonuses.IntBonus4thLevel = false;
            barbarian.SkillPointsCalculator.IntelligenceBonuses.IntBonus8thLevel = false;
            barbarian.SkillPointsCalculator.IntelligenceBonuses.IntBonus12thLevel = true;
            barbarian.SkillPointsCalculator.IntelligenceBonuses.IntBonus16thLevel = true;
            barbarian.SkillPointsCalculator.IntelligenceBonuses.IntBonus20thLevel = false;

            barbarian.SkillPointsCalculator.CalculateSkillPoints(
                    barbarian.CharacterLevel,
                    barbarian.GetModifier(barbarian.Intelligence),
                    barbarian.SkillClassModifier,
                    true);

            Console.WriteLine(barbarian.SkillPointsCalculator.SkillPoints);
        }

        private static void TestDiceRoll()
        {
            DiceRollerManager diceRollerManager = new DiceRollerManager
            {
                NumberOfRolls = 10,
                NumberOfDiceFaces = 20,
                Modifier = 2,
                AddEachRoll = false
            };

            diceRollerManager.AccumulateValues();
            foreach (var roll in diceRollerManager.Rolls)
            {
                Console.Write(roll + " ");
            }
            Console.WriteLine("\ntotal = " + diceRollerManager.TotalRolledValues);
        }
    }
}
