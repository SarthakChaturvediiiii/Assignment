using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class GameManger : MonoBehaviour
{
    public float timeRemaining = 60f; 
    public TextMeshProUGUI timerText;
    public int score = 0; 
    public TextMeshProUGUI scoreText;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; 
            UpdateTimerDisplay();
        }
        else
        {
            TimeIsUp();
        }
        Debug.LogWarning(score);
        UpdateScoreDisplay();
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = string.Format("Timer- {0:00}:{1:00}", minutes, seconds);
    }

    void TimeIsUp()
    {
        Debug.Log("Time is up!");
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name.Contains("Point"))
        {
            score++;
            PlayerPrefs.SetInt("Score", score);
            
            collision.gameObject.SetActive(false);
            
            UpdateScoreDisplay();
        }
    }

    void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + PlayerPrefs.GetInt("Score").ToString(); 
    }
}
