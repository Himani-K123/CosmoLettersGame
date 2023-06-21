using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toUsernameScreenHard : MonoBehaviour
{
    public void UsernameScreen()
    {
        Debug.Log("Clicked");
        GameManage gameManage = GameManage.Instance;

        if (gameManage != null)
        {
            gameManage.Time = 15;
            gameManage.LOD = "Hard";
            SceneManager.LoadScene("UsernameScreen", LoadSceneMode.Additive);
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


;