using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextInputHandler : MonoBehaviour
{
    public TMP_InputField inputField;
    public WordChecker wordChecker;
    public PopupMessageTMP popupMessage;

    public void StoreText()
    {
        string enteredText = inputField.text;
        // Do something with the entered text, such as storing it in a variable or saving it to a file.
        Debug.Log(enteredText);
    }

    public void Start()
    {
        wordChecker.onCharacterInvalid += ShowInvalidCharacterMessage;
        wordChecker.onWordInvalid += ShowInvalidWordMessage;
        wordChecker.onWordValid += ShowValidWordMessage;
    }

    public void SubmitText()
{
    string enteredText = inputField.text;
    Debug.Log("Submitted Text: " + enteredText);
    // Perform any actions with the entered text here

    char[] charList = { 'a', 'b', 'c', 'd', 'e' };

    bool isMadeOfChars = wordChecker.CheckWord(enteredText, charList);
    Debug.Log("Word is made of characters: " + isMadeOfChars);

    // Reset the input field's text
    inputField.text = "";
}

private void ShowInvalidCharacterMessage(string message)
{
    popupMessage.ShowMessage(message);
}

private void ShowInvalidWordMessage(string message)
{
    popupMessage.ShowMessage(message);
}

private void ShowValidWordMessage(string message)
{
    popupMessage.ShowMessage(message);
}

}

