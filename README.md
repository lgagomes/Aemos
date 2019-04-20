# Aemos (Formerly "Char Util")
Tool written in C# to help with some calculations to Dungeons &amp; Dragons 3.5 

Features (so far):
   - For spellcasting:
      * Spells DC per level, based on key attribute (Intelligence, Charisma or Wisdom)
      * Extra spells per level, based on key attribute (Intelligence, Charisma or Wisdom)
      * Available spells slots per day, based on character class and level
      * Known spells per level (only to Bard and Sorcerer)
      * Keeps track of spells slots used
  
   - For all classes:
      * Carrying capacity (showed in kilograms or pounds), based on: 
         - character's strenght
         - characters's size
         - character's number of legs (biped or quadruped)
      
   - Base Attack Bonus, based on level for all classes
   - Skill points calculation, based on class, level and intelligence score
   - Class / non-class skill max rank points, based on character level
   - XP calculation for character level up (NOT  Challenge Rating (CR) / Encounter calculation).
   - Dice Roller
   
# Why "Aemos"?
In the [Eisenhorn book series](http://wh40k.lexicanum.com/wiki/Eisenhorn_(Novel_Series)) set in the [Warhammer 40K](http://wh40k.lexicanum.com/wiki/Warhammer_40,000) universe, [Uber Aemos](http://wh40k.lexicanum.com/wiki/Uber_Aemos) is a character who provides Eisenhorn with useful information and complex computation. That's the goal of this tool, to help players and dungeon masters to save time when dealing with boring calculations and / or searching the books for specific tables.

# Changelog:
- v 1.8: Beginning of new feature addition: spell compendium, a database with (almost) every spell PHB, Complete Divine and Epic Level's Book
- v 1.7.1: Completely replaces XMLs by data in a local database
- v 1.7: Changes access to spells per day. Instead of XML, spells are now loaded from a local database
