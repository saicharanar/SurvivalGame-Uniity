using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UIControllerEndScene : MonoBehaviour
{
    public Button RetryButton;
    public Button ExitButton;
    public Label ScoreText;
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        RetryButton = root.Q<Button>("Retry");
        ExitButton = root.Q<Button>("Exit");
        
        ScoreText = root.Q<Label>("ScoreBox");
        ScoreText.text = Score.currentScore.ToString();

        RetryButton.clicked += ReloadGame;
        ExitButton.clicked += ExitGame;
    }

    private void ReloadGame()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
