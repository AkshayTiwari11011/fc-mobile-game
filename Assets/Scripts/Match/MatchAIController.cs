using UnityEngine;

/// <summary>
/// MatchAIController - AI logic for opponent team in matches
/// </summary>
public class MatchAIController : MonoBehaviour
{
    public enum AIDifficulty { Easy, Medium, Hard, Expert }

    [SerializeField] private AIDifficulty difficulty = AIDifficulty.Medium;
    [SerializeField] private MatchManager matchManager;

    private float attackIntensity = 0.5f;
    private float defenseIntensity = 0.5f;

    private void Start()
    {
        if (matchManager == null)
            matchManager = FindObjectOfType<MatchManager>();

        SetDifficultySettings();
    }

    /// <summary>
    /// Set AI behavior based on difficulty
    /// </summary>
    private void SetDifficultySettings()
    {
        switch (difficulty)
        {
            case AIDifficulty.Easy:
                attackIntensity = 0.3f;
                defenseIntensity = 0.2f;
                Debug.Log("[MatchAI] Difficulty set to Easy");
                break;

            case AIDifficulty.Medium:
                attackIntensity = 0.5f;
                defenseIntensity = 0.5f;
                Debug.Log("[MatchAI] Difficulty set to Medium");
                break;

            case AIDifficulty.Hard:
                attackIntensity = 0.7f;
                defenseIntensity = 0.7f;
                Debug.Log("[MatchAI] Difficulty set to Hard");
                break;

            case AIDifficulty.Expert:
                attackIntensity = 0.9f;
                defenseIntensity = 0.9f;
                Debug.Log("[MatchAI] Difficulty set to Expert");
                break;
        }
    }

    /// <summary>
    /// Get AI difficulty level
    /// </summary>
    public AIDifficulty GetDifficulty() => difficulty;

    /// <summary>
    /// Set AI difficulty level
    /// </summary>
    public void SetDifficulty(AIDifficulty newDifficulty)
    {
        difficulty = newDifficulty;
        SetDifficultySettings();
    }

    /// <summary>
    /// Get attack intensity based on difficulty
    /// </summary>
    public float GetAttackIntensity() => attackIntensity;

    /// <summary>
    /// Get defense intensity based on difficulty
    /// </summary>
    public float GetDefenseIntensity() => defenseIntensity;

    /// <summary>
    /// Make tactical decision based on match situation
    /// </summary>
    public string MakeTacticalDecision()
    {
        if (matchManager == null) return "Normal";

        int currentScore = matchManager.HomeTeam.GetTotalPoints() - matchManager.AwayTeam.GetTotalPoints();
        int minutesRemaining = 90 - matchManager.CurrentMinute;

        // If losing, increase attack
        if (currentScore < 0 && minutesRemaining > 15)
        {
            attackIntensity = Mathf.Min(attackIntensity + 0.2f, 1f);
            return "AllOut Attack";
        }

        // If winning, increase defense
        if (currentScore > 0 && minutesRemaining < 20)
        {
            defenseIntensity = Mathf.Min(defenseIntensity + 0.2f, 1f);
            return "Park the Bus";
        }

        // Normal play
        return "Balanced";
    }

    /// <summary>
    /// Decide whether AI should attempt a shot
    /// </summary>
    public bool ShouldAttemptShot(float opponentDefenseRating)
    {
        float shotChance = attackIntensity * (100f - opponentDefenseRating) / 100f;
        return Random.value < shotChance;
    }

    /// <summary>
    /// Decide whether AI should make a risky pass
    /// </summary>
    public bool ShouldMakeRiskyPass()
    {
        return Random.value < attackIntensity;
    }

    /// <summary>
    /// Decide substitution based on match performance
    /// </summary>
    public bool ShouldMakeSubstitution(Team aiTeam)
    {
        if (matchManager == null) return false;

        // Substitute if a player is injured
        foreach (Player player in aiTeam.Squad)
        {
            if (player.IsInjured && aiTeam.Squad.Count > 11)
            {
                Debug.Log($"[MatchAI] Substituting injured player: {player.PlayerName}");
                return true;
            }
        }

        // Substitute if stamina is critically low (rare)
        if (Random.value < 0.1f) // 10% chance per check
        {
            Debug.Log("[MatchAI] Making tactical substitution");
            return true;
        }

        return false;
    }

    /// <summary>
    /// Simulate AI shooting accuracy
    /// </summary>
    public float GetShotAccuracy(int shootingRating)
    {
        // Base accuracy from player shooting stat, modified by difficulty
        float baseAccuracy = shootingRating / 99f;
        float difficultyBonus = (float)difficulty / (float)AIDifficulty.Expert;
        return Mathf.Clamp01(baseAccuracy + difficultyBonus * 0.2f);
    }

    /// <summary>
    /// Simulate AI passing accuracy
    /// </summary>
    public float GetPassAccuracy(int passingRating)
    {
        float baseAccuracy = passingRating / 99f;
        float difficultyBonus = (float)difficulty / (float)AIDifficulty.Expert;
        return Mathf.Clamp01(baseAccuracy + difficultyBonus * 0.15f);
    }

    /// <summary>
    /// Get AI team formation for current situation
    /// </summary>
    public string GetRecommendedFormation(Team aiTeam)
    {
        int teamOverall = aiTeam.TeamOverall;
        int goalsAhead = matchManager.AwayTeamGoals - matchManager.HomeTeamGoals;

        // Defensive formation when ahead
        if (goalsAhead > 0)
        {
            return "5-3-2";
        }

        // Attacking formation when behind
        if (goalsAhead < 0)
        {
            return "4-3-3";
        }

        // Balanced formation when tied
        return "4-2-3-1";
    }
}
