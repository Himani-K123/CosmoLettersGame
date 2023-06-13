using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToAgarGame : MonoBehaviour
{
    public void AgarGame()
    {
        SceneManager.LoadScene("AgarGame", LoadSceneMode.Additive);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
