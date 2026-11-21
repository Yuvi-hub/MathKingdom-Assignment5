# Math Kingdom — Dramatic Elements

## Assignment 5 — Your Game: Selection

**Selected game:** Math Kingdom  
**Genre:** 2D platforming and arithmetic puzzle  
**Audience:** Players who enjoy short, accessible platforming challenges with a clear mathematical goal  
**Current playable prototype:** One level, three number pickups (2, 3, 5), target sum 10, 90-second timer, and a goal portal.

This document distinguishes the **current implementation** from **planned extensions**. The existing prototype is the starting point for the next development stage.

## 1. Challenge (אתגר)

The player's challenge is to traverse platforms, time jumps, collect number pickups, and reach the portal with exactly the target sum before time runs out. Failure can result from falling into the hazard, running out of time, or entering the portal with the wrong total.

**Current challenge:** The single prototype level uses numbers 2, 3 and 5, target sum 10, and a 90-second timer. The player must manage movement, jumping, and collection order.

**Planned difficulty levels:**
- **Easy:** Broad platforms, longer timer, and obvious numbers.
- **Medium:** Narrower gaps, alternative routes, and more pickups than needed.
- **Hard:** Moving hazards, tighter time limits, and number combinations that require choosing a subset rather than collecting everything.

Difficulty will increase gradually: first movement, then collecting, then choosing the right arithmetic combination under time pressure. To avoid unfair difficulty, each level should be tested to ensure at least one achievable route and solution.

## 2. Flow (זרימה)

The game aims to keep the player between boredom and frustration. Controls are simple, the objective is visible, and each collected number produces immediate score feedback. Short levels and quick restarts encourage experimentation.

The intended flow cycle is: observe the target → plan a route → execute jumps → collect numbers → compare the sum → reach the portal → receive clear success/failure feedback. The timer adds urgency without making the first level excessively demanding.

A player should feel progress from learning a jump, collecting a number, and seeing the score update. Failure should explain what happened (wrong sum, hazard, or time), allowing the player to adapt on the next attempt.

## 3. Amusement (שעשוע)

Beyond the central mathematical objective, the platforming itself can be enjoyable: experimenting with jumps, finding alternate routes, and trying to finish with time to spare.

**Currently available:** Free movement, jumping, and replaying the level.  
**Planned optional amusements:** Hidden decorative number symbols, a harmless bouncing platform, and a nonessential scenic route. These should never obstruct the main objective or make the arithmetic requirement unclear.

## 4. Emotions (רגשות)

The design aims to evoke **curiosity** when players first see the level, **concentration** during platform jumps, **tension** as time runs low, **satisfaction** when the sum reaches the target, and **relief/pride** upon reaching the portal.

Bright, distinct colors communicate object roles: yellow numbers are collectibles, green marks the goal, and red marks danger. Immediate messages after success or failure help make outcomes understandable rather than arbitrary.

## 5. Backstory (סיפור־רקע)

The Math Kingdom's ancient Number Gates once kept its regions connected. A magical disturbance scattered the numbers needed to open the gates. The player is a young courier tasked with recovering the correct numerical combinations to restore the kingdom's paths.

The prototype does not currently display this story in Unity. It is presented as a **planned narrative framing** and in the accompanying interactive Twine introduction (`math-kingdom-story.html`). The story should be optional and short so it does not interrupt repeated attempts.

## 6. Characters (דמויות)

**The Courier (player):** Curious, determined, and resourceful. The player controls movement and decides how to approach platforms and pickups.

**The Gatekeeper (planned supporting character):** A guardian who explains why each Number Gate needs a particular sum. The Gatekeeper provides hints but does not solve the level for the player.

**The Number Storm (environmental antagonist):** A magical disruption rather than a speaking villain. It creates the game's conflict by scattering numbers and destabilizing paths.

The current Unity prototype represents the player as a simple colored shape and does not include dialogue or NPCs. Characters are narrative concepts to develop in later versions.

## 7. Plot (עלילה)

**Central conflict:** The kingdom's gates are sealed because their numerical seals are broken. The Courier must gather numbers that add up to the required total while overcoming environmental obstacles.

**Beginning:** The Gatekeeper explains the first sealed gate and the sum of 10.  
**Development:** The player learns how numbers and movement work together; future gates require harder decisions.  
**Climax:** The Courier chooses the correct combination and reaches the final gate before the Number Storm closes the path.  
**Resolution:** The gate opens and the route is restored, setting up further regions.

The interactive introduction is provided in `math-kingdom-story.html` and the editable Twine source in `math-kingdom-story.twee`. It offers short choices, multiple responses, and a route to the game objective. The Twine story is narrative material; it is not yet integrated into the Unity game.

## 8. World Building (בניית עולם)

The Math Kingdom is a whimsical realm of floating stone platforms, number shrines, and gates activated by arithmetic. Its geography consists of connected regions, each associated with a different numerical challenge. The Number Storm has broken the routes between them.

The world's culture values exploration and mathematical ingenuity. Gatekeepers maintain the pathways, and couriers travel between regions to restore them. The economy and politics are not central to the current short platforming experience, so they remain intentionally lightweight rather than introducing unrelated lore.

**Current representation:** A single abstract platform level.  
**Planned expansion:** Distinct themed regions (addition valley, subtraction bridge, multiplication tower) with recognizable environments and progressively more complex goals.

## 9. Meta-game (מטא־משחק)

The current prototype has no persistent progression, shop, multiplayer system, or achievements. The player can replay the level and try to finish more efficiently.

Potential future meta-game features include a level-selection map, stars for completing a level quickly, optional challenges, and a collection journal showing previously solved gate sums. These would reward replay without being required to complete the core game.

## 10. Live Ops / Dynamic Configuration (ניהול חי)

The updated Unity project demonstrates a **runtime-configurable player movement speed**.

**Implementation:** `LiveOpsSpeedControl.cs` adds an on-screen panel with **Slower (-)** and **Faster (+)** buttons. The panel calls `PlatformPlayer.SetMoveSpeed`, which changes the actual speed used by `FixedUpdate` while the game is running. The current value is displayed immediately and is clamped to the range 2–12 units per second.

**How to demonstrate:**
1. Open `Assets/Scenes/Main.unity` and press Play.
2. Hold D or Right Arrow to move and observe the normal speed (6).
3. Click **Faster (+)** twice while still in Play mode; the displayed speed becomes 8.
4. Move again and observe the faster horizontal motion.
5. Click **Slower (-)** twice to return to 6.
6. Stop and restart Play mode; the initial speed is restored.

This is **local runtime configuration**, not a remote server-controlled Live Ops system. It demonstrates the requested ability to change a configuration value during gameplay without recompiling or restarting. A future extension could read the value from a remote configuration service.

## Submission References

- **GitHub repository:** REPLACE_WITH_MATH_KINGDOM_GITHUB_URL
- **Playable itch.io game:** REPLACE_WITH_MATH_KINGDOM_ITCH_URL
- **Interactive story:** `math-kingdom-story.html`
- **Editable Twine story source:** `math-kingdom-story.twee`
- **Runtime code:** `Assets/Scripts/Player/LiveOpsSpeedControl.cs` and `PlatformPlayer.cs`
