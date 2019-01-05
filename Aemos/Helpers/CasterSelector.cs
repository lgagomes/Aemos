using Aemos.CharacterClasses;

namespace Aemos.Helpers
{
    public class CasterSelector
    {
        // determines if a spellcastar is based on charisma, intelligence or wisdom
        public void Select(Spellcaster spellcaster, string keyAttributeName, int attributeScore)
        {
            switch (keyAttributeName)
            {
                case "Charisma":
                    spellcaster.Charisma = attributeScore;
                    spellcaster.KeyAttributeModifier = spellcaster.GetModifier(spellcaster.Charisma);
                    break;

                case "Intelligence":
                    spellcaster.Intelligence = attributeScore;
                    spellcaster.KeyAttributeModifier = spellcaster.GetModifier(spellcaster.Intelligence);
                    break;

                case "Wisdom":
                    spellcaster.Wisdom = attributeScore;
                    spellcaster.KeyAttributeModifier = spellcaster.GetModifier(spellcaster.Wisdom);
                    break;
            }
        }

        // determines if a spellcaster also have known spells
        public bool IsKnownlerOfSpells(Spellcaster spellcaster)
        {
            if (spellcaster is KnowlerOfSpells)
                return true;
            else
                return false;
        }
    }
}
