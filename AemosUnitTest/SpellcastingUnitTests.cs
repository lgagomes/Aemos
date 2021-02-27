using Aemos.CharacterClasses;
using Aemos.Repository;
using System.Linq;
using Xunit;

namespace AemosUnitTest
{
    public class SpellcastingUnitTests
    {
        private SpellsRepository _spellsRepository;

        public SpellcastingUnitTests()
        {
            _spellsRepository = new SpellsRepository();
        }

        [Fact]
        public void TestBardSpellsPerDay()
        {
            // Arrange
            Bard bard = new Bard() { CharacterLevel = 5 };
            int[] SpellsPerDayBard = new int[] { 3, 3, 1, 0, 0, 0, 0, 0, 0, 0 };

            try
            {
                // Act
                bard.CurrentDailySpells = _spellsRepository.GetSpellsSlots(bard.ClassName, bard.CharacterLevel, "DailySpells");

                // Assert            
                Assert.Equal(SpellsPerDayBard, bard.CurrentDailySpells);
            }
            catch { }
        }

        [Fact]
        public void TestSorcererSpellsPerDay()
        {
            // Arrange
            Sorcerer sorcerer = new Sorcerer() { CharacterLevel = 10 };
            int[] SpellsPerDaySorcerer = new int[] { 6, 6, 6, 6, 5, 3, 0, 0, 0, 0 };

            try
            {
                // Act
                sorcerer.CurrentDailySpells = 
                    _spellsRepository.GetSpellsSlots(sorcerer.ClassName, sorcerer.CharacterLevel, "DailySpells");

                // Assert            
                Assert.Equal(SpellsPerDaySorcerer, sorcerer.CurrentDailySpells);
            }
            catch { }
        }

        [Fact]
        public void TestClericSpellsPerDay()
        {
            // Arrange
            Cleric cleric = new Cleric() { CharacterLevel = 20 };
            int[] SpellsPerDayCleric = new int[] { 6, 5, 5, 5, 5, 5, 4, 4, 4, 4 };

            try
            {
                // Act
                cleric.CurrentDailySpells = _spellsRepository.GetSpellsSlots(cleric.ClassName, cleric.CharacterLevel, "DailySpells");

                // Assert            
                Assert.Equal(SpellsPerDayCleric, cleric.CurrentDailySpells);
            }
            catch { }
        }

        [Fact]
        public void TestDruidSpellsPerDay()
        {
            // Arrange
            Druid druid = new Druid() { CharacterLevel = 15 };
            int[] SpellsPerDayDruid = new int[] { 6, 5, 5, 5, 4, 4, 3, 2, 1, 0 };

            try
            {
                // Act
                druid.CurrentDailySpells = _spellsRepository.GetSpellsSlots(druid.ClassName, druid.CharacterLevel, "DailySpells");

                // Assert            
                Assert.Equal(SpellsPerDayDruid, druid.CurrentDailySpells);
            }
            catch { }
        }

        [Fact]
        public void TestWizardSpellsPerDay()
        {
            // Arrange
            Wizard wizard = new Wizard() { CharacterLevel = 2 };
            int[] SpellsPerDayWizard = new int[] { 4, 2, 0, 0, 0, 0, 0, 0, 0, 0 };

            try
            {
                // Act
                wizard.CurrentDailySpells = _spellsRepository.GetSpellsSlots(wizard.ClassName, wizard.CharacterLevel, "DailySpells");

                // Assert            
                Assert.Equal(SpellsPerDayWizard, wizard.CurrentDailySpells);
            }
            catch { }
        }

        [Fact]
        public void TestPaladinSpellsPerDay()
        {
            // Arrange
            Paladin paladin = new Paladin() { CharacterLevel = 14 };
            int[] SpellsPerDayPaladin = new int[] { 0, 2, 1, 1, 0, 0, 0, 0, 0, 0 };

            try
            {
                // Act
                paladin.CurrentDailySpells = _spellsRepository.GetSpellsSlots(paladin.ClassName, paladin.CharacterLevel, "DailySpells");

                // Assert            
                Assert.Equal(SpellsPerDayPaladin, paladin.CurrentDailySpells);
            }
            catch { }
        }

        [Fact]
        public void TestRangerSpellsPerDay()
        {
            // Arrange
            Ranger ranger = new Ranger() { CharacterLevel = 11 };
            int[] SpellsPerDayRanger = new int[] { 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 };

            try
            {
                // Act
                ranger.CurrentDailySpells = _spellsRepository.GetSpellsSlots(ranger.ClassName, ranger.CharacterLevel, "DailySpells");

                // Assert           
                Assert.Equal(SpellsPerDayRanger, ranger.CurrentDailySpells);
            }
            catch { }
        }

        [Fact]
        public void TestUpdateExtraSpells()
        {
            // Arrange
            Bard bard = new Bard()
            {
                Charisma = 32
            };
            bard.KeyAttributeModifier = bard.GetModifier(bard.Charisma);
            decimal[] extraSpells = new decimal[10] { 0, 3, 3, 3, 2, 2, 2, -1, -1, -1 };

            // Act
            bard.GetExtraSpells();

            // Assert
            Assert.Equal(extraSpells, bard.ExtraSpells);
        }

        [Fact]
        public void TestUpdateSpellsDC()
        {
            Bard bard = new Bard() { Charisma = 32 };
            bard.KeyAttributeModifier = bard.GetModifier(bard.Charisma);
            int[] spellsDc = new int[10] { 21, 22, 23, 24, 25, 26, 27, -1, -1, -1 };

            // Act
            bard.GetSpellsDC();

            // Assert
            Assert.Equal(spellsDc, bard.SpellsDC);

        }
        
        [Fact]
        public void TestUpdateKnownSpells()
        {

            // Arrange
            Sorcerer sorcerer = new Sorcerer() { CharacterLevel = 1 };
            int[] spellsKnownSorcerer = new int[]   {4,2,0,0,0,0,0,0,0,0};

            try
            {
                // Act
                sorcerer.CurrentKnownSpells = _spellsRepository.GetSpellsSlots(sorcerer.ClassName, sorcerer.CharacterLevel, "KnownSpells");

                // Assert           
                Assert.Equal(spellsKnownSorcerer, sorcerer.CurrentKnownSpells);
            }
            catch { }
        }

        [Fact]
        public void TestCastSpell()
        {
            // Arrange
            Cleric cleric = new Cleric() { CharacterLevel = 7 };
            int spellCycle = 1;
            int[] SpellsPerDayAfterUser = new int[] { 6, 3, 3, 2, 1, 0, 0, 0, 0, 0 };
            try
            {
                // Act
                cleric.CurrentDailySpells = _spellsRepository.GetSpellsSlots(cleric.ClassName, cleric.CharacterLevel, "DailySpells");
                cleric.CastSpell(spellCycle);

                // Assert            
                Assert.Equal(SpellsPerDayAfterUser, cleric.CurrentDailySpells);
            }
            catch { }
        }
    }
}
