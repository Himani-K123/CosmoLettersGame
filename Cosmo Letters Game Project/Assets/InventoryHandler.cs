using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryHandler : MonoBehaviour
{
    public TMP_Text messageText;
    private List<char> charList; // Moved the declaration here

    // Start is called before the first frame update
    void Start()
    {
        charList = ColliderObject.inventory;
        string output = "Inventory: " + string.Join(", ", charList);
    }

    // Update is called once per frame
    void Update()
    {
        string output = "Inventory: " + string.Join(", ", charList);
        messageText.text = output;
    }
}
