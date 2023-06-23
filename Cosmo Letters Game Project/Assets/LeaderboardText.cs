using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LeaderboardText : MonoBehaviour
{
    void Start()
    {
        // Get the Text component attached to the game object
        Text textComponent = GetComponent<Text>();
        GameManage gameManage = GameManage.Instance;

        // Set the text property to the desired value
        textComponent.text = gameManage.UserName + gameManage.LOD + gameManage.Score;
    }

}
