using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    private GameManage gameManage;
    private float timerDuration; // Duration of the timer in seconds

    private float timer; // Current value of the timer
    private bool isTimerActive; // Flag to track the timer state

    private TMP_Text timerText; // Reference to the timer text component
    private Button tmpButton; // Reference to the TextMeshPro button

    private void Start()
    {
        gameManage = GameManage.Instance;

        if (gameManage != null)
        {
            timerDuration = gameManage.Time;
        }
        else
        {
            timerDuration = 60f;
        }

        // Get the reference to the timer text component
        timerText = GetComponentInChildren<TMP_Text>();

        // Get the reference to the TextMeshPro button component
        tmpButton = GameObject.Find("Button").GetComponent<Button>();

        // Attach the button click event listener
        tmpButton.onClick.AddListener(OnButtonClicked);

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

                // Trigger the TextMeshPro button click
                OnButtonClicked();

                // You can add any desired logic here after the timer reaches zero
            }
        }
    }

    // Method to stop the timer externally if needed
    public void StopTimer()
    {
        isTimerActive = false;
    }

    // Method to handle the button click event
    private void OnButtonClicked()
    {
        // Place your button click logic here
    }
}

