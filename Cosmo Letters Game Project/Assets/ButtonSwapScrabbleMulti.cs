using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSwapScrabbleMulti : MonoBehaviour
{
    //public string Scrabble2Multiplayer; // The name of the scene you want to load

    public void SwapScreen()
    {
        Debug.Log("Clicked2");
        
        SceneManager.LoadScene("Scrabble2Multiplayer", LoadSceneMode.Single);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}