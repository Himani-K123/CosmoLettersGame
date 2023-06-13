using UnityEngine;
using System.Collections.Generic;

public class DataReceiver : MonoBehaviour
{
    private void Start()
    {
        // Retrieve the stored char list data from PlayerPrefs
        string charListData = PlayerPrefs.GetString("CharListData");

        // Convert the string back to a char list
        char[] charArray = charListData.ToCharArray();
        List<char> receivedCharList = new List<char>(charArray);

        // Do whatever you need with the received char list
        Debug.Log("Received Char List: " + new string(charArray));
    }
}
