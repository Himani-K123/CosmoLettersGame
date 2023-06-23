using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("PlayMenu", LoadSceneMode.Additive);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log(SceneManager.UnloadScene("MainMenu"));
    }
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Test()
    {
        Debug.Log("Test");
    }
}
