using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toUsernameScreenMedium : MonoBehaviour
{
    public void UsernameScreen()
    {
        Debug.Log("Clicked");
        GameManage gameManage = GameManage.Instance;

        if (gameManage != null)
        {
            gameManage.Time = 30f;
            gameManage.LOD = "Medium";
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


