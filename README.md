# Cities Skyline: Difficulty Tuning Mod

## Difficulty Levels
- **Easy.** All costs are halved. Upkeep decreased by 25%. ₡200,000 at start. Higher demand. Easier level up. Less pollution. Steeper roads allowed.
- **Normal.** Almost the same as vanilla.
- **Advanced.** Close to the Hard Mod which comes with the game.
- **Hard.** Even harder.
- **Expert.** Recommended for experienced players.
- **Challenge.** Very accurate city planning required.
- **Impossible.** Near the limit of playability. (Added a screenshot to demonstrate that the difficulty "Impossible" is playable.)
- **Custom.** A lot of customizable parameters.

Initial money and loan amount are increased for high difficulties.

## Special Difficulty Levels
These special levels are made for fun and experimenting.
- **Free.** Construction is free. Upkeep is halved. Demand is very high. Land value and service score are not required for buildings to level up. No ground and noise pollution from power, water, and garbage facilities. Initial money is zero.
- **₡500,000 at start.** Normal difficulty with ₡500,000 at start.
- **Demand 100%.** Demand is always 100%. Other settings are normal.
- **Free public transport.** Normal difficulty. Zero cost and upkeep for public transport.
- **Low city.** Very high levelup requirements for buildings. Other settings are normal.
- **Hard and fast.** Impossible difficulty with zero construction cost. Still hard but much less waiting time. You can construct anything even when the balance is negative. Initial money is zero.

Difficulty settings are available from the Main Menu.
Main Menu > Options > Mods Settings > Difficulty Tuning Mod

Changing difficulty options during a game is possible, but cost values displayed in the info panels will not update until reloading the game. Better to exit to the Main Menu, change the difficulty options, and load the game again.

## Customizable parameters
Below is the list of the customizable parameters. When you change a difficulty parameter, the game difficulty is automatically set to "Custom".

**Construction and upkeep cost**  
Separate for service buildings, public transportation, roads and for everything else (park, plazas, pathways, trees, monuments).
Strictly speaking, the construction cost is not critical. Increasing it even in 100 times will not make the game unplayable. You will just have to wait a very long time before constructing something. The upkeep is what is important.
In general, at higher difficulties, roads are set to be the most expensive - you should plan your traffic ways and road types more thoroughly. On the other hand, public transportation upkeep is not changed much. You do not have to restrain yourself from building a good public transport network.

**Demand offset and multiplier.**  
Calculated by formula (Demand + Offset) * Multiplier
In very general meaning, changing the offset will result in changing the city growth condition (grow or not grow). Changing the multiplier will result in changing the city growth speed (fast grow or slow grow).

**Ground and noise pollution radius**  
Bigger radius for high difficulties. Can be set from 0 (no pollution) to x5 in the custom options. Only power, water, and garbage facilities are affected.

**Relocation cost**  
Varies from 0 (free relocation) to 80% of the construction cost depending on difficulty. In vanilla you can relocate a building at 20% of its cost.

**Maximum slope for roads, railroads, and metro**  
Easy: 30%, normal: 25%, expert: 19%, impossible: 15%. Can be set from 5% (very gentle) to 100% (45 deg.) in the custom options. Setting the slope limit below 15% will make the constructing very tricky (especially near tunnel entrances) and will probably require Fine Road Heights mod. That is why I set the slope limit to only 15% even for the highest difficulty.

**Area cost multiplier**  
Expanding is quite expensive at the higher difficulties.

**Reward percentage**  
Amount of money you get when a milestone is reached. No reward at the higher difficulties.

**Start money amount**  
Starting a game with the default amount of the initial capital, sometimes it is impossible to construct the minimum required facilities at the highest difficulties (depending on map). The start money is increased a little bit for the Challenge and Impossible difficulties. Can be changed from 0 to ₡500.000 in the custom options.

**Loans**  
Loan amount increased for high difficulties. Can be set from x0.25 to x10 in the custom options. Loan length changes by formula (1+x)/2, where x is the loan amount multiplier.
Origin of the formula. If increase the loan amount without changing the loan length, the payment per week would be too high. However, if increase the loan length at the same rate as the loan amount, the repay period would be too long. So I decided to implement the medium way. For example, if increase the loan amount in 3 times, the loan length will be increased in (3+1)/2=2 times.

**Population required to unlock milestones**  
The higher difficulty the later the game stuff is unlocked. Can be set to 0 unlocking everything from the beginning.

**Land value requirements for level up of Residential and Commercial buildings**  

**Service score requirements for level up of Industrial and Office buildings**  

## Additional features
- Unlock purchasing all 25 area tiles, when the last milestone is reached.
- Unlock the "Basic Road Created" milestone from the beginning. (This is very minor thing that removes the requirement to build a piece of two-lane road before building something else.)
- 100% refund from recently built roads at all difficulty levels. (Consider it as an "undo" feature for roads.)
- Steam achievements are enabled for all difficulty levels except Easy and Free. (Yes. You can get achievements with this mod.)

## Translations
- English
- Nederlands
- Deutsch
- Italiano
- Português
- Français
- 日本語
- Русский

## Mod compatibility
- Should be compatible with most mods. Please report about any compatibility issues.
- Made special effort to be compatible with Enhanced Interface mod.
- Using together with a mod that changes costs, level up requirements, or demand, may cause game balance issues.
- In order to be compatible with mods that change road slope limits, the Maximum slope option will be disabled in case one of the following mods is active: "Stricter Slope Limits", "Configurable Slope Limiter", "Slope Limits (WtM)".
