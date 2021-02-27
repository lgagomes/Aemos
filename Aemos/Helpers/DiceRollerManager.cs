using System.Collections.Generic;
using System.Linq;

namespace Aemos.Helpers
{
    public class DiceRollerManager
    {
        public List<int> Rolls { get; private set; }
        public int TotalRolledValues { get; private set; }
        public int NumberOfRolls { get; set; }
        public int NumberOfDiceFaces { get; set; }
        public int Modifier { get; set; } = 0;
        public bool AddEachRoll { get; set; } // defines if we add the modifier after all rolls or after each roll separately
        private Dice Dice { get; set; }

        public void AccumulateValues()
        {
            TotalRolledValues = 0;
            Dice = new Dice(NumberOfDiceFaces);
            Rolls = new List<int>();

            for (int i = 0; i < NumberOfRolls; i++)
            {
                Rolls.Add(Dice.Roll());
            }

            TotalRolledValues = Rolls.Sum();

            TotalRolledValues = (!AddEachRoll)
                ? TotalRolledValues += Modifier
                : TotalRolledValues += (Modifier * NumberOfRolls);          

            CheckNegativeRolledValues();
        }

        // In case of a negative modifier, the total rolled must be at least 1
        private void CheckNegativeRolledValues()
        {
            if (TotalRolledValues < 0)
            {
                TotalRolledValues = 1;
            }
        }
    }
}
