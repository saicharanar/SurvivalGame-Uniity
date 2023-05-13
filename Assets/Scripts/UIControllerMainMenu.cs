using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UIControllerMainMenu : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        startButton = root.Q<Button>("Start");
        exitButton = root.Q<Button>("Exit");

        startButton.clicked += StartGame;
        exitButton.clicked += ExitGame;

    }

    private void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
