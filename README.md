# Obstacle Dodge

Obstacle Dodge is a small Unity game focused on precise movement and getting the Player through obstacles till the end of the route.
The player must navigate a maze-like environment filled with multiple types of hazards
and reach the finish without touching anything dangerous, otherwise, the game restarts.

---

## 🎮 Gameplay Overview
- Start with a **cinematic intro** that showcases the maze and the finish line.
- Navigate your cube-shaped player through the paths.
- Avoid various traps and dynamic obstacles.
- Reach the finish line to win.
- Touching any hazard instantly triggers a **full restart**.

---

## 🧱 Features
### 🎬 Cinematic Introduction
A short camera animation introduces the map and gives players a clear view of the goal and obstacles.

### ⚠️ Dynamic Hazards
The maze contains several types of traps:
- **Spinning bars**
- **Falling blocks**
- **Projectiles fired across the path**
- **Rotating obstacles**
  
Each hazard requires timing and awareness to avoid.

### 🕹 Simple Controls
Move the player through the maze while keeping track of timing and movement patterns.

### 🔁 Restart Logic
If the player touches:
- a wall,
- a spinning arm,
- a falling object,
- a projectile,

…the game instantly restarts to maintain a fast gameplay loop.

---

## 🛠 Technical Notes
- Developed in Unity 6.
- Uses **Cinemachine** for the player camera.
- Includes a **Legacy Animation** intro for the opening cinematic.
- Simple scripts handle movement, hazards, and restart triggers.

---

## 🚀 Goal of the Project
Obstacle Dodge is designed as a small project to learn:
- Unity basics
- Camera control with Cinemachine
- Trigger-based game logic
- Simple animation sequences
- Level design with hazards
