using UnityEngine;

/// <summary>
/// Constants - Game-wide constants and configurations
/// </summary>
public static class Constants
{
    // Game Configuration
    public const int MAX_SQUAD_SIZE = 23;
    public const int STARTING_XI_SIZE = 11;
    public const int STARTING_BALANCE = 5000000;
    public const int MATCH_DURATION = 90; // minutes

    // Player Stats Ranges
    public const int MIN_STAT = 1;
    public const int MAX_STAT = 99;
    public const int PEAK_AGE_MIN = 25;
    public const int PEAK_AGE_MAX = 28;

    // XP & Progression
    public const long XP_PER_LEVEL = 1000;
    public const long XP_PER_GOAL = 50;
    public const long XP_PER_ASSIST = 30;
    public const long XP_PER_MATCH = 100;
    public const long XP_PER_CAREER_MATCH = 500;

    // Rewards
    public const int WIN_BONUS = 50000;
    public const int DRAW_BONUS = 25000;
    public const int LOSS_BONUS = 5000;
    public const int GOAL_REWARD = 1000;
    public const int LEVEL_UP_BONUS = 10000;

    // Player Positions
    public static readonly string[] POSITIONS = 
    {
        "GK",   // Goalkeeper
        "CB",   // Center Back
        "LB",   // Left Back
        "RB",   // Right Back
        "CM",   // Center Midfielder
        "CDM",  // Defensive Midfielder
        "CAM",  // Attacking Midfielder
        "LM",   // Left Midfielder
        "RM",   // Right Midfielder
        "LW",   // Left Winger
        "RW",   // Right Winger
        "ST",   // Striker
        "CF"    // Center Forward
    };

    // Formations
    public static readonly string[] FORMATIONS =
    {
        "4-3-3",
        "4-2-3-1",
        "3-5-2",
        "5-3-2",
        "4-4-2",
        "3-4-3",
        "5-4-1"
    };

    // Match Events
    public static readonly string[] MATCH_EVENTS =
    {
        "GOAL",
        "YELLOW CARD",
        "RED CARD",
        "INJURY",
        "SUBSTITUTION",
        "CORNER",
        "PENALTY",
        "SAVE"
    };

    // AI Difficulty Multipliers
    public const float EASY_MULTIPLIER = 0.7f;
    public const float MEDIUM_MULTIPLIER = 1.0f;
    public const float HARD_MULTIPLIER = 1.3f;
    public const float EXPERT_MULTIPLIER = 1.6f;

    // Injury Duration
    public const int MIN_INJURY_DAYS = 5;
    public const int MAX_INJURY_DAYS = 30;

    // Currency Names
    public const string CURRENCY_NAME = "Credits";
    public const string CURRENCY_SYMBOL = "₹";

    /// <summary>
    /// Get formation description
    /// </summary>
    public static string GetFormationDescription(string formation)
    {
        switch (formation)
        {
            case "4-3-3":
                return "Balanced formation with 4 defenders, 3 midfielders, 3 attackers";
            case "4-2-3-1":
                return "Defensive formation with 2 DMs protecting defense";
            case "3-5-2":
                return "Wide formation with 5 midfielders";
            case "5-3-2":
                return "Very defensive with 5 at the back";
            case "4-4-2":
                return "Classic formation with 4 midfielders";
            case "3-4-3":
                return "Attacking formation with 3 attackers";
            case "5-4-1":
                return "Extremely defensive, counter-attacking style";
            default:
                return "Unknown formation";
        }
    }

    /// <summary>
    /// Check if a position is valid
    /// </summary>
    public static bool IsValidPosition(string position)
    {
        foreach (string pos in POSITIONS)
        {
            if (pos == position)
                return true;
        }
        return false;
    }

    /// <summary>
    /// Check if a formation is valid
    /// </summary>
    public static bool IsValidFormation(string formation)
    {
        foreach (string form in FORMATIONS)
        {
            if (form == formation)
                return true;
        }
        return false;
    }

    /// <summary>
    /// Get position category
    /// </summary>
    public static string GetPositionCategory(string position)
    {
        switch (position)
        {
            case "GK":
                return "Goalkeeper";
            case "CB":
            case "LB":
            case "RB":
                return "Defender";
            case "CM":
            case "CDM":
            case "CAM":
            case "LM":
            case "RM":
                return "Midfielder";
            case "LW":
            case "RW":
            case "ST":
            case "CF":
                return "Attacker";
            default:
                return "Unknown";
        }
    }
}
