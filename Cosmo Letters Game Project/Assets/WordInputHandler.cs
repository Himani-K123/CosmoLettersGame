using UnityEngine;
using TMPro;

public class WordInputHandler : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text resultText;
    public LearningModeWordChecker wordChecker;

    private void Start()
    {
        inputField.onSubmit.AddListener(OnSubmitWord);
        inputField.onValueChanged.AddListener(OnValueChanged);
    }

    public void OnSubmitWord(string inputWord)
    {
        string result = wordChecker.CheckWord(inputWord);
        resultText.text = result;
    }

    public void OnValueChanged(string inputWord)
    {
        // Optionally, you can perform real-time validation or other actions here
    }
}

