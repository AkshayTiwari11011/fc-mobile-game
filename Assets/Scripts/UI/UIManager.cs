using UnityEngine;

/// <summary>
/// UIManager - Manages UI panels and screen navigation
/// </summary>
public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private Canvas mainCanvas;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    /// <summary>
    /// Show main menu screen
    /// </summary>
    public void ShowMainMenu()
    {
        Debug.Log("[UIManager] Showing main menu");
        // TODO: Implement main menu UI
    }

    /// <summary>
    /// Show team management screen
    /// </summary>
    public void ShowTeamManagement()
    {
        Debug.Log("[UIManager] Showing team management");
        // TODO: Implement team management UI
    }

    /// <summary>
    /// Show match screen
    /// </summary>
    public void ShowMatchScreen()
    {
        Debug.Log("[UIManager] Showing match screen");
        // TODO: Implement match UI
    }

    /// <summary>
    /// Show player details
    /// </summary>
    public void ShowPlayerDetails(Player player)
    {
        Debug.Log($"[UIManager] Showing details for {player.PlayerName}");
        // TODO: Implement player details UI
    }

    /// <summary>
    /// Show team selection
    /// </summary>
    public void ShowTeamSelection()
    {
        Debug.Log("[UIManager] Showing team selection");
        // TODO: Implement team selection UI
    }

    /// <summary>
    /// Show settings screen
    /// </summary>
    public void ShowSettings()
    {
        Debug.Log("[UIManager] Showing settings");
        // TODO: Implement settings UI
    }

    /// <summary>
    /// Show notification popup
    /// </summary>
    public void ShowNotification(string title, string message)
    {
        Debug.Log($"[UIManager] Notification: {title} - {message}");
        // TODO: Implement notification UI
    }

    /// <summary>
    /// Show loading screen
    /// </summary>
    public void ShowLoadingScreen()
    {
        Debug.Log("[UIManager] Showing loading screen");
        // TODO: Implement loading UI
    }

    /// <summary>
    /// Hide all panels
    /// </summary>
    public void HideAllPanels()
    {
        Debug.Log("[UIManager] Hiding all panels");
        // TODO: Hide all UI elements
    }

    /// <summary>
    /// Close current screen
    /// </summary>
    public void CloseCurrentScreen()
    {
        Debug.Log("[UIManager] Closing current screen");
        // TODO: Implement screen closing logic
    }
}
