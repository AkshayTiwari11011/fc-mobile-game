using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// GameManager - Main singleton managing game state, player data, and team data
/// </summary>
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private List<Team> teams = new List<Team>();
    [SerializeField] private Team playerTeam;
    [SerializeField] private int playerCurrency = 5000000; // Starting budget
    [SerializeField] private int playerLevel = 1;
    [SerializeField] private long playerXP = 0;

    public Team PlayerTeam => playerTeam;
    public int PlayerCurrency => playerCurrency;
    public int PlayerLevel => playerLevel;
    public long PlayerXP => playerXP;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        InitializeGame();
    }

    /// <summary>
    /// Initialize game on startup
    /// </summary>
    private void InitializeGame()
    {
        Debug.Log("[GameManager] Initializing game...");
        LoadPlayerData();
        LoadTeamsData();
    }

    /// <summary>
    /// Load or create player team
    /// </summary>
    private void LoadPlayerData()
    {
        // TODO: Implement save/load system
        if (playerTeam == null)
        {
            playerTeam = new Team("My FC", "MyFC");
            playerTeam.AddPlayer(new Player("John Doe", 25, "ST", 85));
            playerTeam.AddPlayer(new Player("Alex Smith", 28, "CM", 82));
            playerTeam.AddPlayer(new Player("Mike Johnson", 30, "GK", 88));
            Debug.Log("[GameManager] Player team created");
        }
    }

    /// <summary>
    /// Load all teams data
    /// </summary>
    private void LoadTeamsData()
    {
        // TODO: Load from JSON or database
        if (teams.Count == 0)
        {
            teams.Add(new Team("Manchester United", "MU"));
            teams.Add(new Team("Liverpool FC", "LFC"));
            teams.Add(new Team("Chelsea FC", "CFC"));
            Debug.Log($"[GameManager] Loaded {teams.Count} teams");
        }
    }

    /// <summary>
    /// Add currency (salary, match rewards, etc)
    /// </summary>
    public void AddCurrency(int amount)
    {
        playerCurrency += amount;
        Debug.Log($"[GameManager] Added {amount}. New balance: {playerCurrency}");
    }

    /// <summary>
    /// Spend currency (player transfer, training, etc)
    /// </summary>
    public bool SpendCurrency(int amount)
    {
        if (playerCurrency >= amount)
        {
            playerCurrency -= amount;
            Debug.Log($"[GameManager] Spent {amount}. Remaining: {playerCurrency}");
            return true;
        }
        else
        {
            Debug.LogWarning($"[GameManager] Insufficient funds! Need {amount}, have {playerCurrency}");
            return false;
        }
    }

    /// <summary>
    /// Add XP to player and handle level ups
    /// </summary>
    public void AddXP(long amount)
    {
        playerXP += amount;
        int xpPerLevel = 1000;

        while (playerXP >= xpPerLevel)
        {
            playerXP -= xpPerLevel;
            playerLevel++;
            Debug.Log($"[GameManager] Player leveled up! New level: {playerLevel}");
            OnPlayerLevelUp();
        }
    }

    /// <summary>
    /// Called when player levels up
    /// </summary>
    private void OnPlayerLevelUp()
    {
        // Add bonus currency
        AddCurrency(10000);
        // TODO: Unlock new features, increase player team stats, etc
    }

    /// <summary>
    /// Get all teams
    /// </summary>
    public List<Team> GetAllTeams() => new List<Team>(teams);

    /// <summary>
    /// Get team by ID
    /// </summary>
    public Team GetTeamById(string teamId)
    {
        return teams.Find(t => t.TeamID == teamId);
    }

    /// <summary>
    /// Save game progress
    /// </summary>
    public void SaveGame()
    {
        // TODO: Implement save system (JSON, Firebase, etc)
        Debug.Log("[GameManager] Game saved");
    }

    /// <summary>
    /// Load game progress
    /// </summary>
    public void LoadGame()
    {
        // TODO: Implement load system
        Debug.Log("[GameManager] Game loaded");
    }

    private void OnApplicationQuit()
    {
        SaveGame();
    }
}
