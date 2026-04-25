# 🐸 Doodle Jump — Recreated with Data Structures & Algorithms

> A C# recreation of the classic arcade game **Doodle Jump**, built as a course project for **CSC-221: Data Structures and Algorithms** at Bahria University, Karachi Campus.

---

## 📋 Project Info

| Field | Details |
|---|---|
| **Course** | CSC-221 — Data Structures and Algorithm Lab |
| **Term** | Fall 2024 |
| **Class** | BSE-3B |
| **Institution** | Bahria University, Karachi Campus |
| **Course Instructor** | Engr. Dr. Sohaib Ahmed |
| **Lab Instructor** | Engr. Saniya Sarim |

---

## 👥 Team Members

| Name | Enrollment # | Role |
|---|---|---|
| **Khizar Akram** | 02-131232-064 | Team Lead — Project management & module integration |
| **Hamza Khaliq** | 02-131232-059 | Monte Carlo algorithm for platform generation |
| **Hassan Asif** | 02-131232-113 | Hashing Tree for object management & collision detection |
| **Shamraiz Tasawar** | 02-131232-112 | Game physics, jump mechanics & user input handling |

---

## 🎮 About the Game

This project recreates **Doodle Jump** — a game where a character continuously jumps upward on procedurally generated platforms — using object-oriented programming (OOP) principles in **C#**. The implementation demonstrates how core data structures and algorithms directly power real game mechanics.

---

## 🧠 Algorithms & Data Structures Used

### 🎲 Monte Carlo Algorithm
Used for **random platform generation**. Probabilistic logic controls:
- Platform position validity and reachability
- Bonus and enemy spawn rates
- Dynamic difficulty scaling (fewer platforms, moving platforms over time)

### 🌳 Hashing Trees
Used for **object state management**:
- Tracks active/inactive platforms, enemies, and collectibles
- Enables real-time updates as the player progresses
- Optimizes collision detection lookups

### 📦 AABB Collision Detection (Axis-Aligned Bounding Box)
Checks for rectangular overlaps between the player, platforms, bullets, and enemies by calculating positional deltas.

```csharp
public bool CheckCollision(Transform obj1, Transform obj2)
{
    return (obj1.position.X < obj2.position.X + obj2.size.Width &&
            obj1.position.X + obj1.size.Width > obj2.position.X &&
            obj1.position.Y < obj2.position.Y + obj2.size.Height &&
            obj1.position.Y + obj1.size.Height > obj2.position.Y);
}
```

### 🔁 Object Pooling
Reuses objects like bullets and enemies to avoid frequent memory allocation and improve runtime performance.

### 🔐 SHA-256 Secure Score Hashing
Player scores are hashed using SHA-256 to prevent unauthorized tampering.

```csharp
public static string HashScore(int score)
{
    using (SHA256 sha256Hash = SHA256.Create())
    {
        byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(score.ToString()));
        StringBuilder builder = new StringBuilder();
        foreach (byte b in bytes)
            builder.Append(b.ToString("x2"));
        return builder.ToString();
    }
}
```

---

## ⚙️ Features

- **Procedural Platform Generation** — Platforms dynamically appear as the player ascends
- **Collision Detection** — Accurate AABB-based interactions between all game objects
- **Realistic Physics** — Gravity and acceleration simulate natural jumping and falling
- **Scoring System** — Points awarded for platforms cleared and enemies defeated
- **Dynamic Difficulty** — Challenge increases over time with fewer/moving platforms
- **Bonuses & Power-ups** — Springs, jetpacks, and collectibles
- **Enemy AI** — Multiple enemy types with different behaviors
- **Secure Score Storage** — SHA-256 hashed scores resist tampering

---

## 🏗️ Architecture

The project follows **Object-Oriented Programming (OOP)** principles with modular, reusable components:

| Class/Interface | Responsibility |
|---|---|
| `Player` | Player movement and interactions |
| `Platform` | Platform representation and behavior |
| `Bonus` | Power-ups (springs, jetpacks) |
| `Enemy` | Enemy types, sizes, and positions |
| `Physics` | Gravity calculations and collision responses |
| `PlatformController` | Manages platforms, enemies, and bonuses |
| `Transform` | Encapsulates position and size for all game objects |

### Programming Paradigms

- **Object-Oriented Programming (OOP)** — Modular, encapsulated components
- **Event-Driven Programming** — Scoring and collisions driven by in-game events
- **Randomized Algorithms** — Platform generation and enemy spawning with controlled randomness
- **Secure Data Management** — SHA-256 hashing for tamper-resistant score storage

---



## 🚀 Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later recommended)
- A C# compatible IDE (Visual Studio, Rider, or VS Code with C# extension)

### Running the Project
```bash
git clone https://github.com/your-username/doodle-jump-dsa.git
cd doodle-jump-dsa
dotnet run
```

---

## 🔮 Future Improvements

- Multiplayer mode
- Additional power-ups and platform types
- AI-driven enemies with pathfinding
- Leaderboard with persistent score storage
- Mobile/web port

---

## 📄 License

This project was developed for academic purposes at Bahria University, Karachi Campus. All rights reserved by the respective group members.

---

*Submitted for CSC-221 — Data Structures and Algorithm Lab | Fall 2024*
