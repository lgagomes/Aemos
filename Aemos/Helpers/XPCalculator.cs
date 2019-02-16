using System;

namespace Aemos.Helpers
{
    public class XPCalculator
    {
        private const int XP_CONSTANT = 500;

        public long CalculateXPByLevel(long level)
        {
            return level * (level - 1) * XP_CONSTANT;
        }

        public long CalculateLevelByXP(long xpAmmount)
        {
            /* xp equation is: 
             * 
             * XP = Level * (Level - 1) * 500
             *  = 500 * (Level^2) - 500 * Level
             *  
             * or
             *   -500 * (Level^2) + 500 * Level + XP = 0
             *   
             * By using Bhaskara to find the roots of the equation, we can get the Level 
             * by a given ammount of XP. For this specifc function we may return 
             * Math.Abs((-b + squareRootDelta) / (2 * a)) + 1 or simply 
             * (-b - squareRootDelta) / (2 * a) */

            long a = -XP_CONSTANT, b = XP_CONSTANT, delta, squareRootDelta, res;

            delta = GetDelta(a, b, xpAmmount);
            squareRootDelta = (long)Math.Sqrt(delta);
            res = (-b - squareRootDelta) / (2 * a);
            return res;
        }

        public long CalculateLevelBySumXP(long firstXpAmmount, long secondXPAmmount)
        {
            return (CalculateLevelByXP(firstXpAmmount + secondXPAmmount));
        }

        private long GetDelta(long a, long b, long c)
        {
            return (b * b) - (4 * a * c);
        }
    }
}
