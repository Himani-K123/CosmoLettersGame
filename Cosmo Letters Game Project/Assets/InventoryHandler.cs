using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryHandler : MonoBehaviour
{
    public TMP_Text messageText;
    public TMP_Text messageText2;
    private List<char> charList; // Moved the declaration here
    private List<char> charList2; //decleration for the second list for the second player

    // Start is called before the first frame update
    void Start()
    {
        charList = ColliderObject.inventory;
        string output = "Inventory: " + string.Join(", ", charList);
        charList2 = ColliderObject.inventory2;
        string output2 = "Inventory: " + string.Join(", ", charList2);
    }

    // Update is called once per frame
    void Update()
    {
        string output = "Inventory: " + string.Join(", ", charList);
        messageText.text = output;
        string output2 = "Inventory: " + string.Join(", ", charList2);
        messageText2.text = output2;
    }
}
