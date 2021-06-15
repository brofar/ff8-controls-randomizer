# Controls Randomizer

Randomizes controller controls while playing FF8 by reading and shuffling the control mapping in the game's memory while you play.
Does not affect keyboard controls/mapping.

## Options

### Full Random
* OFF: Directional controls and buttons are randomized in separate pools.
* ON: Everything is randomized in the same pool.

### Randomize on map change instead of timer
* OFF: Performs the randomization on a timed interval (set by the user)
* ON: Performs the randomization whenever the party changes screens in game

Restores your original controller configuration when you click stop, so do that before quitting the game or the randomizer.

## Background
FF8 (Steam) stores the controller map in memory. These addresses are changed by the game when the player goes to Menu > Config > Controls.  If we change these addresses programatically, the game accepts the changes immediately and uses the new controls.


The addresses are as follows:

|Offset (EN)|Length|Description|
|----|----|----|
|FF8_EN.exe+18D0228|1 byte|L2|
|FF8_EN.exe+18D0229|1 byte|R2|
|FF8_EN.exe+18D022A|1 byte|L1|
|FF8_EN.exe+18D022B|1 byte|R1|
|FF8_EN.exe+18D022C|1 byte|Walk/Cancel|
|FF8_EN.exe+18D022D|1 byte|Menu|
|FF8_EN.exe+18D022E|1 byte|Select/Talk|
|FF8_EN.exe+18D022F|1 byte|Card Game|
|FF8_EN.exe+18D0234|1 byte|Up|
|FF8_EN.exe+18D0235|1 byte|Right|
|FF8_EN.exe+18D0236|1 byte|Down|
|FF8_EN.exe+18D0237|1 byte|Left|

Offsets for FR are (Offset(EN) - 0x328)