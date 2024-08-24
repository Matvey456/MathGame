using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    [SerializeField] private Button toMenuButton;

    private void Start() => toMenuButton.onClick.AddListener(ToMenu);

    private void ToMenu() => SceneManager.LoadScene(0);
}