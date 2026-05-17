# FC Mobile - Football Game (Unity)

A mobile football (soccer) game built with Unity for iOS and Android platforms. Inspired by FC Mobile and similar manager-style football games.

## 🎮 Features

### Core Gameplay
- **Squad Management** - Build and manage your team with customizable formations
- **Player Progression** - Level up players, improve stats, and unlock abilities
- **Real-time Matches** - Play matches with tactical decision-making
- **Career Mode** - Progress through leagues and tournaments
- **Transfer Market** - Buy/sell players and manage your budget

### Player System
- **Dynamic Stats** - Pace, Shooting, Passing, Dribbling, Defense, Physical
- **Leveling System** - XP-based progression with stat improvements
- **Injuries & Recovery** - Realistic injury mechanics
- **Player Roles** - GK, CB, LB, RB, CM, CAM, ST, LW, RW

### Team Features
- **Squad Depth** - Up to 23 players per team
- **Formation Support** - 4-3-3, 4-2-3-1, 3-5-2, 5-3-2, etc.
- **Starting XI Selection** - Choose your best lineup
- **Team Chemistry** - Better chemistry = better performance

### Match System
- **Tactical AI** - AI opponents with different difficulty levels
- **Live Match Events** - Goals, fouls, substitutions, injuries
- **Match Statistics** - Possession, shots, pass accuracy tracking

## 📁 Project Structure

```
Assets/
├── Scripts/
│   ├── Core/
│   │   └── GameManager.cs          # Main game controller
│   ├── UI/
│   │   └── UIManager.cs            # UI panel management
│   ├── Player/
│   │   └── Player.cs               # Player class & logic
│   ├── Team/
│   │   └── Team.cs                 # Team management
│   ├── Match/
│   │   ├── MatchManager.cs         # Match flow & scoring
│   │   └── MatchAIController.cs    # AI opponent logic
│   ├── Audio/
│   │   └── AudioManager.cs         # Sound effects & music
│   └── Utils/
│       └── Constants.cs            # Game constants
├── Scenes/
│   ├── MainMenu.unity
│   ├── TeamManagement.unity
│   ├── MatchScene.unity
│   └── CareerMode.unity
├── Prefabs/
│   ├── PlayerCard.prefab
│   ├── MatchEventUI.prefab
│   └── FormationUI.prefab
├── Sprites/
│   ├── Players/
│   ├── Teams/
│   ├── UI/
│   └── Icons/
├── Audio/
│   ├── Music/
│   ├── SFX/
│   └── Commentary/
├── Resources/
│   └── PlayerDatabase.json
└── Plugins/
```

## 🛠️ Setup Instructions

### Requirements
- **Unity 2022 LTS** or later
- **Visual Studio** or Rider (C# IDE)
- **Android SDK** (for Android builds)
- **Xcode** (for iOS builds - macOS only)

### Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/AkshayTiwari11011/fc-mobile-game.git
   cd fc-mobile-game
   ```

2. **Open in Unity:**
   - Launch Unity Hub
   - Click "Add" → Select project folder
   - Open with Unity 2022 LTS or later

3. **Import Dependencies:**
   - Window → TextMesh Pro → Import TMP Essential Resources
   - Window → TextMesh Pro → Import TMP Examples & Extras (optional)

4. **Run the Game:**
   - Go to Assets/Scenes
   - Open `MainMenu.unity`
   - Press Play (Ctrl/Cmd + P)

## 🎯 Development Roadmap

### Phase 1: Foundation (Current)
- [x] Project structure setup
- [ ] Player system implementation
- [ ] Team management system
- [ ] Game manager & data persistence

### Phase 2: UI & Menus
- [ ] Main menu UI
- [ ] Team management UI
- [ ] Player card & stats UI
- [ ] Settings & options

### Phase 3: Core Gameplay
- [ ] Match system
- [ ] AI opponent logic
- [ ] Real-time match events
- [ ] Match UI & HUD

### Phase 4: Features
- [ ] Transfer market
- [ ] Career mode progression
- [ ] League system
- [ ] Tournament modes

### Phase 5: Polish & Optimization
- [ ] Mobile optimization
- [ ] UI/UX refinement
- [ ] Audio integration
- [ ] Performance optimization

### Phase 6: Multiplayer (Optional)
- [ ] Multiplayer matchmaking
- [ ] Real-time PvP matches
- [ ] Leaderboards
- [ ] Cloud save system

## 📱 Platform Build Instructions

### Android Build
1. File → Build Settings
2. Select Android
3. Player Settings → Configure for Android
4. Build & Run (requires Android SDK)

### iOS Build
1. File → Build Settings
2. Select iOS
3. Player Settings → Configure for iOS
4. Build to Xcode project
5. Open in Xcode and submit to App Store

## 🔧 Code Architecture

### Design Patterns Used
- **Singleton Pattern** - GameManager, UIManager, AudioManager
- **Observer Pattern** - Event system for match events
- **State Machine** - Match states (pregame, playing, halftime, postgame)
- **MVC Pattern** - Model-View-Controller for UI screens

### Data Serialization
- **JSON** - Player & team data storage
- **PlayerPrefs** - Save/load game progress
- **Scriptable Objects** - Configuration data

## 🎮 Controls

### Mobile Controls
- **Tap** - Select player/action
- **Swipe Up** - Pass
- **Swipe Down** - Shoot
- **Swipe Left/Right** - Change player
- **Double Tap** - Sprint
- **Hold** - Power meter for actions

### Editor Controls (Testing)
- **WASD** - Move camera
- **Mouse Scroll** - Zoom
- **Space** - Pause match
- **ESC** - Menu

## 📊 Game Statistics

- **Player Count**: 500+ unique players
- **Teams**: 32+ teams
- **Formations**: 8+ formation types
- **Match Duration**: 90 minutes (real-time adjustable)
- **Leagues**: 5 leagues (future update)

## 🐛 Known Issues

- [ ] AI difficulty balancing (WIP)
- [ ] UI responsiveness on smaller screens
- [ ] Performance optimization needed for older devices

## 🤝 Contributing

1. Create a new branch: `git checkout -b feature/your-feature`
2. Make your changes and commit: `git commit -am 'Add new feature'`
3. Push to the branch: `git push origin feature/your-feature`
4. Submit a pull request

## 📝 License

This project is licensed under the MIT License - see LICENSE file for details.

## 👨‍💻 Author

**Akshay Tiwari** (@AkshayTiwari11011)

## 🙏 Credits

- Inspired by FC Mobile, FIFA Mobile, and similar football games
- Unity Documentation & Community
- Open-source community for assets and tools

## 📞 Support

For issues, feature requests, or questions:
- Open a GitHub Issue
- Email: support@example.com
- Discord: [Join our server]

---

**Happy Coding! ⚽🎮**
