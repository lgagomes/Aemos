using Aemos.Repository;

namespace Aemos.CharacterClasses
{
    public class KnowlerOfSpells : Spellcaster
    {
        public int[] CurrentKnownSpells { get; set; }

        public void GetKnownSpells()
        {
            CurrentKnownSpells = SpellsRepository.GetSpells(ClassName, CharacterLevel, MaxSpellCycle, Resources.SpellResources.KnownSpellsComplement);
        }
    }
}
