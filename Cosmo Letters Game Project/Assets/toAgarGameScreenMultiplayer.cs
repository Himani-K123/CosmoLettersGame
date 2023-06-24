using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toAgarGameScreenMultiplayer: MonoBehaviour
{
    public void UsernameScreen()
    {
        Debug.Log("Clicked");
        GameManage gameManage = GameManage.Instance;

        if (gameManage != null)
        {
            gameManage.Time = 30f;
            gameManage.LOD = "Multiplayer";
            SceneManager.LoadScene("AgarMultiplayer", LoadSceneMode.Additive);
        }
        else
        {
            Debug.LogError("GameManage instance is null!");
        }
    }

    public void Back()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}



