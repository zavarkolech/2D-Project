# 2D Platformer (Prototype)

A classic 2D platformer prototype built in **Unity (C#)** using Unity's 2D physics engine (`Rigidbody2D` and `Collider2D`).

## 📸 Gameplay Preview
<img width="464" height="240" alt="Гиф 2D" src="https://github.com/user-attachments/assets/90e11f2d-6cbd-46a7-abff-98528716d4d9" />



## ⚙️ Key Features & Mechanics
* **2D Physics & Movement:** Implemented responsive horizontal movement and jumping mechanics using `Rigidbody2D`.
* **Ground Detection:** Configured 2D colliders and ground-check logic (`OverlapCircle` / `Raycast2D`) to prevent infinite mid-air jumping.

## 🎮 Controls
* **A / D or Left / Right Arrows:** Move
* **Space:** Jump

## 📂 Project Structure (Where to look)
The core C# scripts are located in `Assets/Scripts/`:
* `Hero.cs` — handles horizontal movement, jumping, and ground detection.
