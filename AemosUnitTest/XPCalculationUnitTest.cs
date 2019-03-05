using Aemos.Helpers;
using Xunit;

namespace AemosUnitTest
{
    public class XPCalculationUnitTest
    {
        [Fact]
        public void TestCalculateXPByLevel()
        {
            // Arrange
            XPCalculator xpCalculator = new XPCalculator();
            long expectedXP = 66000,
                actualXP,
                level = 12;

            // Act
            actualXP = xpCalculator.CalculateXPByLevel(level);

            // Assert
            Assert.Equal(expectedXP, actualXP);
        }

        [Fact]
        public void TestCalculateLevelByXP()
        {
            // Arrange
            XPCalculator xpCalculator = new XPCalculator();
            long xp = 119999, 
                expectedLevel = 15, 
                actualLevel;

            // Act
            actualLevel = xpCalculator.CalculateLevelByXP(xp);

            // Assert
            Assert.Equal(expectedLevel, actualLevel);
        }

        [Fact]
        public void TestCalculateLevelBySumXP()
        {
            // Arrange
            XPCalculator xpCalculator = new XPCalculator();
            long firstXpAmmount = 36000,
                secondXpAmmount = 78000,
                expectedLevel = 15,
                actualLevel;
                

            // Act
            actualLevel = xpCalculator.CalculateLevelBySumXP(firstXpAmmount, secondXpAmmount);

            // Assert
            Assert.Equal(expectedLevel, actualLevel);
        }

        // Must change the visibility of XPCalculator.GetDelta() to public befor run this test
        /*
        [Fact]
        public void TestGetDelta()
        {
            // Arrange
            XPCalculator xpCalculator = new XPCalculator();
            long a = 1, 
                b = -5, 
                c = 6, 
                expectedDelta = 1, 
                actualDelta;

            // Act
            actualDelta = xpCalculator.GetDelta(a, b, c);

            // Assert
            Assert.Equal(expectedDelta, actualDelta);
        }
        */
    }
}
