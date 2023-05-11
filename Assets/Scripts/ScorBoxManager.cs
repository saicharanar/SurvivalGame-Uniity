using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScorBoxManager : MonoBehaviour
{
    private TMP_Text ScoreBox;

    private void Start()
    {
        ScoreBox = FindObjectOfType<TMP_Text>();
    }

    public void UpdateScore(int scoreToAdd)
    {
        var currentScore = int.Parse(ScoreBox.text);
        ScoreBox.text = (currentScore + scoreToAdd).ToString();
    }
}
