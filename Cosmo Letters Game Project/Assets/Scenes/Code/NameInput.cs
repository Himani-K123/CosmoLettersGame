using UnityEngine;
using TMPro;

public class NameInput : MonoBehaviour
{
    public string playerName;
    public TMP_InputField inputField;


    public void SaveName()
    {
        playerName = inputField.text;
        GameManager gameManager = GameManager.Instance;
        gameManager.UserName = playerName;
        Debug.Log("Player Name: " + playerName);
    }
}

