using Aemos.Repository;
using System;

namespace Aemos.CharacterClasses
{
    public class Spellcaster : BaseClass
    {
        public int MaxSpellCycle { get; set; }
        public string KeyAttribute { get; set; }
        public decimal KeyAttributeModifier { get; set; }
        public int[] SpellsDC { get; set; }
        public decimal[] ExtraSpells { get; set; }
        public int FirstDC { get; set; }
        public int [] CurrentDailySpells { get; set;}

        public Spellcaster()
        {
            SpellsDC = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            ExtraSpells = new decimal[10] { 0, -1, -1, -1, -1, -1, -1, -1, -1, -1 }; ;
            KeyAttributeModifier = 0;
        }

        public void GetDailySpells()
        {
            CurrentDailySpells = SpellsRepository.GetSpellsSlots(ClassName, CharacterLevel, MaxSpellCycle, Resources.SpellResources.DailySpellsComplement);
        }

        public void GetExtraSpells()
        {
            for (int i = 1; i < MaxSpellCycle; i++)
            {
                ExtraSpells[i] = Math.Ceiling((KeyAttributeModifier - (i - 1)) / 4);
            }
        }

        public void GetSpellsDC()
        {
            for (int i = FirstDC; i < MaxSpellCycle; i++)
            {
                SpellsDC[i] = 10 + (int)KeyAttributeModifier + i;
            }
        }

        public bool CastSpell(int spellCycle)
        {
            if (CurrentDailySpells[spellCycle] > 0)
            {
                CurrentDailySpells[spellCycle]--;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
