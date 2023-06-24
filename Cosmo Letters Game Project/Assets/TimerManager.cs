using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class TimerManager : MonoBehaviour
{
    private GameManage gameManage; 
    private float timerDuration; // Duration of the timer in seconds

    private float timer; // Current value of the timer
    private bool isTimerActive; // Flag to track the timer state

    public TMP_Text timerText; // Reference to the timer text component

    private void Start()
    {
        gameManage = GameManage.Instance;

        if (gameManage != null)
        {
            timerDuration = gameManage.Time*2;
        }
        else
        {
            timerDuration = 60f;
        }

        // Attach the button click event listener

        // Start the timer
        timer = timerDuration;
        isTimerActive = true;
    }

    private void Update()
    {
        // Update the timer value only if it's active
        if (isTimerActive)
        {
            // Update the timer value
            timer -= Time.deltaTime;

            // Update the timer text
            timerText.text = timer.ToString("F1");

            // Check if the timer has reached zero
            if (timer <= 0f)
            {
                // Stop the timer
                isTimerActive = false;
                GameManage gameManage = GameManage.Instance;
                gameManage.Score = Score.Score1;
                SceneManager.LoadScene("Leaderboard", LoadSceneMode.Single);
            }
        }
    }

    // Method to stop the timer externally if needed
    public void StopTimer()
    {
        isTimerActive = false;
    }
}

