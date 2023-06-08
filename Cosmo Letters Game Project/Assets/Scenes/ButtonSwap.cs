using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections.Generic;

public class ButtonSwap : MonoBehaviour
{
    public string ScrabbleScreen; // The name of the scene you want to load

    public void OnButtonClick()
    {
        // Convert char list to string
        List<char> charList = ColliderObject.inventory;
        string charListData = new string(charList.ToArray());

        // Store the char list data in PlayerPrefs
        PlayerPrefs.SetString("CharListData", charListData);

        // Load the target scene
        SceneManager.LoadScene(ScrabbleScreen);
    }
}


