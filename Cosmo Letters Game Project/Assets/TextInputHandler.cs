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

    // The TextInputHandler class handles user input and interacts with the
    //WordChecker class.

    // Store the text entered in the input field
    public void StoreText()
    {
        string enteredText = inputField.text;
        // The StoreText method is responsible for storing or processing the entered text.
        // You can add your own logic inside this method.
        Debug.Log(enteredText);
    }

    // Subscribe to wordChecker events when the script starts
    public void Start()
    {
        // The Start method is called when the script starts and attaches event 
        //handlers for invalid and valid words
        // to the corresponding events in the WordChecker class.
        wordChecker.onCharacterInvalid += ShowInvalidCharacterMessage;
        wordChecker.onWordInvalid += ShowInvalidWordMessage;
        wordChecker.onWordValid += ShowValidWordMessage;
    }

    // Handle the submission of text
    public void SubmitText()
    {
        string enteredText = inputField.text;
        Debug.Log("Submitted Text: " + enteredText);

        // Access the character list from ColliderObject.inventory
        List<char> charList = ColliderObject.inventory;
        Debug.Log(charList);

        char[] arr = new char[charList.Count];
        bool isMadeOfChars = wordChecker.CheckWord(enteredText, charList);
        Debug.Log("Word is made of characters: " + isMadeOfChars);

        // Reset the input field's text
        inputField.text = "";
    }

    // Show a popup message for an invalid character
    private void ShowInvalidCharacterMessage(string message)
    {
        // The ShowInvalidCharacterMessage method shows a popup message
        //when an invalid character is encountered in the word.
        popupMessage.ShowMessage(message);
    }

    // Show a popup message for an invalid word
    private void ShowInvalidWordMessage(string message)
    {
        // The ShowInvalidWordMessage method shows a popup message when an
        //invalid word is detected.
        popupMessage.ShowMessage(message);
    }

    // Show a popup message for a valid word
    private void ShowValidWordMessage(string message)
    {
        // The ShowValidWordMessage method shows a popup message when a
        //valid word is entered.
        popupMessage.ShowMessage(message);
    }
}
