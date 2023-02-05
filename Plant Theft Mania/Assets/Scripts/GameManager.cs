using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoSingleton<GameManager>
{
    public int score = 0;
    public TextMeshProUGUI scoreText;

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = $"Score: {score}";
    }

    public void ResetScore()
    {
        score = 0;
        scoreText.text = $"Score: {score}";
    }
}
