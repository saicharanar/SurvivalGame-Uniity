using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // [SerializeField] private GameObject RestartButton;
    [SerializeField] private TMP_Text Scorebox;
    private AudioSource[] allAudioSources;

    public void Awake() {
        allAudioSources = FindObjectsOfType<AudioSource>();
    }

    private void StopAllAudio() {
        foreach (var audioSource in allAudioSources)
        {
            audioSource.Stop();
        }
    }
    
    public void EndGame(Slider slider)
    {
        if (slider.value <= 0)
        {
            Debug.Log("Ended");
            Time.timeScale = 0;
            StopAllAudio();
            Score.currentScore = int.Parse(Scorebox.text);
            SceneManager.LoadScene("EndScene");
            // RestartButton.SetActive(true);
        }
    }
}
