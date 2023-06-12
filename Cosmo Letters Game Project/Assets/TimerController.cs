using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public float timerDuration = 60f; // Duration of the timer in seconds

    private float timer; // Current value of the timer
    private bool isTimerActive; // Flag to track the timer state

    private Text timerText; // Reference to the timer text component
    private Button buttonToClick; // Reference to the button to be clicked

    private void Start()
    {
        // Get the reference to the timer text component
        timerText = GetComponentInChildren<Text>();

        // Get the reference to the button named "button"
        buttonToClick = GameObject.Find("Button").GetComponent<Button>();

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

                // Trigger the button click
                buttonToClick.onClick.Invoke();

                // You can add any desired logic here after the timer reaches zero
            }
        }
    }

    // Method to stop the timer externally if needed
    public void StopTimer()
    {
        isTimerActive = false;
    }
}

