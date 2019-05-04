using Aemos.Repository;

namespace Aemos.CharacterClasses
{
    public class KnowlerOfSpells : Spellcaster
    {
        public int[] CurrentKnownSpells { get; set; }

        public void GetKnownSpells()
        {
            CurrentKnownSpells = SpellsRepository.GetSpellsSlots(ClassName, CharacterLevel, Resources.SpellResources.KnownSpellsComplement);
        }
    }
}
