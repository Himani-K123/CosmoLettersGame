using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toUsernameScreenEasy : MonoBehaviour
{
    public void UsernameScreen()
    {
        Debug.Log("Clicked");
        GameManage gameManage = GameManage.Instance;

        if (gameManage != null)
        {
            gameManage.Time = 45f;
            gameManage.LOD = "Easy";
            SceneManager.LoadScene("UsernameScreen", LoadSceneMode.Additive);
            SceneManager.UnloadScene("PlayMenu");
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
