using UnityEngine;
using TMPro;

public class NameInput : MonoBehaviour
{
    public string playerName;
    public TMP_InputField inputField;


    public void SaveName()
    {
        playerName = inputField.text;
        Debug.Log("Player Name: " + playerName);
    }
}

