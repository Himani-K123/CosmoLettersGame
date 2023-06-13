using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    private InputField inputField;

    private void Start()
    {
        // Find the Input Field GameObject using its tag or name
        GameObject inputFieldObject = GameObject.FindGameObjectWithTag("YourInputFieldTag"); // Replace "YourInputFieldTag" with the tag you assigned to the Input Field GameObject

        // Get the InputField component from the GameObject
        inputField = inputFieldObject.GetComponent<InputField>();
    }

    public void HandleInput()
    {
        string inputWord = inputField.text;
        // Process the input word
        Debug.Log("Input word: " + inputWord);
    }
}

