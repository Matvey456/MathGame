using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPanel, settingsMenuPanel;
    [SerializeField] private Button startButton, settingsButton, quitButton;

    private void Start()
    {
        startButton.onClick.AddListener(StartGame);
        settingsButton.onClick.AddListener(SettingsGame);
        quitButton.onClick.AddListener(QuitGame);
    }

    private void StartGame() => SceneManager.LoadScene(1);
    
    private void SettingsGame()
    {
        settingsMenuPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
    }
    
    private void QuitGame() => Application.Quit();
}