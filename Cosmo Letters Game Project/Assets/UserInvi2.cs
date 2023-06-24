using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UserInvi2 : MonoBehaviour
{
    public TMP_Text messageText;

    // Start is called before the first frame update
    void Start()
    {
        //GameManager gameManager = GameManager.Instance;
        //string name = gameManager.UserInventory;
        messageText.text = name;
        /*foreach (char c in ColliderObject.inventory)
        {
            messageText.text += c;
        }*/
        
        string concat = string.Join(",", ColliderObject.inventory2);
 
        messageText.text = "Inventory: " + concat;
    }
}
