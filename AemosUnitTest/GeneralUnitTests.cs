using Aemos.CharacterClasses;
using Aemos.Helpers;
using Xunit;

namespace AemosUnitTest
{
    public class GeneralUnitTests
    {
        [Fact]
        public void TestPositiveModifier()
        {
            // Arrange
            Cleric cleric = new Cleric("cleric") { Wisdom = 44 /* Act */ };
            cleric.KeyAttributeModifier = cleric.GetModifier(cleric.Wisdom);

            // Assert
            Assert.Equal(17, cleric.KeyAttributeModifier);
        }

        [Fact]
        public void TestNegativeModifier()
        {
            // Arrange
            Cleric cleric = new Cleric("cleric") { Wisdom = 6 /* Act*/ };
            cleric.KeyAttributeModifier = cleric.GetModifier(cleric.Wisdom);

            // Assert
            Assert.Equal(-2, cleric.KeyAttributeModifier);
        }

        [Fact]
        public void TestCarryingCapacity()
        {
            // Arrange
            LoadCalculator load = new LoadCalculator();
            int str = 39;
            double[] lbs = { 5600, 5601, 11200, 11201, 16800, 16800, 33600, 84000 };
            double[] kgs = { 2800, 2800.5, 5600, 5600.5, 8400, 8400, 16800, 42000 };

            // Act
            load.CalculateLoad(str, 5, true);

            // Assert
            Assert.Equal(lbs, load.LoadsLbs);
            Assert.Equal(kgs, load.LoadsKgs);
        }

        [Fact]
        public void TestBaseAttackBonus()
        {
            // Arrange
            Barbarian barbarian = new Barbarian("barbarian") { CharacterLevel = 11 };
            Monk monk = new Monk("monk") { CharacterLevel = 6 };
            Wizard wizard = new Wizard("wizard") { CharacterLevel = 20 };

            double[] barbarianTemplate = { 11, 6, 1, 0 };
            double[] monkTemplate = { 4, 0, 0, 0 };
            double[] wizardTemplate = { 10, 5, 0, 0 };

            // Act
            barbarian.CalculateBaseAttackBonus();
            monk.CalculateBaseAttackBonus();
            wizard.CalculateBaseAttackBonus();

            // Assert
            Assert.Equal(barbarianTemplate, barbarian.BaseAttackBonus);
            Assert.Equal(monkTemplate, monk.BaseAttackBonus);
            Assert.Equal(wizardTemplate, wizard.BaseAttackBonus);
        }

        [Fact]
        public void TestMonkFuryBlows()
        {
            // Arrange
            Monk monk = new Monk("monk") { CharacterLevel = 18 };
            double[] template = { 13, 13, 13, 8, 3 };

            // Act
            monk.CalculateFuryOfBlowsBonus();

            // Assert
            Assert.Equal(template, monk.FuryOfBlowsBonus);
        }

        [Fact]
        public void TestRoll()
        {
            // Arrange
            Dice dice = new Dice(6);
            int rolledValue;

            // Act
            rolledValue = dice.Roll();

            // Assert           
            Assert.InRange(rolledValue, 1, 6);
        }
    }
}
