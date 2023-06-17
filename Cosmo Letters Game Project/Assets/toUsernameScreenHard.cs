using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toUsernameScreenHard : MonoBehaviour
{
    public void UsernameScreen()
    {
        Debug.Log("Clicked");
        GameManager gameManager = GameManager.Instance;
        gameManager.Time = 15;
        SceneManager.LoadScene("UsernameScreen", LoadSceneMode.Additive);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}

