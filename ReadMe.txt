ASSIGNMENT 01 - COIN CHASE

Names: 
ליאן אבו עודה - 215540543
תסנים נאטור - 323118794
Unity version: 6000.3.26f1 (Unity 6.3 LTS), 2D project
Scene: Assets/Scenes/Assignment_01


HOW TO PLAY
Move the white capsule with W, A, S, D and collect coins (orange 50, green 20,
blue 10). The red enemy always chases you. Reach 1000 points and the Console prints
"you won". If the enemy touches you, it prints "you lose". In both cases the game stops.


WHAT WE DID
- Player and enemy move with Rigidbody2D.MovePosition inside FixedUpdate.
- Coins are created at runtime with Instantiate, from a base prefab "Coin" and
  3 Prefab Variants (value and color are set in the Editor). The type and the position
  are random, and the position range is set in the Editor. A batch of 5 coins is
  created at the start, and again when all 5 are collected.
- Triggers and tags: a coin is destroyed only when the player touches it
  (CompareTag "Coin"). If the enemy touches a coin, nothing happens.


EXTRAS (only topics covered in class)
- Sorting Layers (coins are drawn under the characters), plus a dark arena square and
  camera background.
- A coroutine that raises the enemy's speed over time, up to a maximum set in the
  Inspector.
- A pulsing animation (Animator) on the base Coin prefab, inherited by the variants.
- The score is printed to the Console and shown on screen (TextMeshPro on a Canvas).
- The game stops with EditorApplication.isPlaying = false.
