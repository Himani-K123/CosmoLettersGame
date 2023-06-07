using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextInputHandler : MonoBehaviour
{
    public TMP_InputField inputField;

    public void StoreText()
    {
        string enteredText = inputField.text;
        // Do something with the entered text, such as storing it in a variable or saving it to a file.
        Debug.Log(enteredText);
    }

    public void SubmitText()
    {
        string enteredText = inputField.text;
        Debug.Log("Submitted Text: " + enteredText);
        // Perform any actions with the entered text here
    }  


}
