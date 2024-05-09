# Mabinogi Stat Calculator
This is an application intended to roughly simulate a character's stat values (their damage, defense values, etc.). 
Stat inputs are taken from a character's modified primary stats (yellow-colored values pertaining to HP, MP, Stamina, Str, etc.) and fed through calculations.
The results are roughly accurate minus a plethora of different modifiers.

This is currently a work in progress and a personal learning experience in C#, WPF, and XAML. 
I am making an attempt to follow the MVVM pattern, but pardon me if many things in general are incorrect.

Current functions as of May 9, 2024:
- Ability to input character's stats for the simple stats.
- Skill tabs for (almost) every talent, though still empty.

Future plans:
- Importing skill values for each rank, respective icons from a local database
- Weapon customization (standard and special upgrades, enchants, etc. that affect character damage values)
- Box for additional modifiers (totems and all that other stuff)
- Functions for importing/exporting/saving of character/weapon/skill info
- Window for damage calculations
- And more
