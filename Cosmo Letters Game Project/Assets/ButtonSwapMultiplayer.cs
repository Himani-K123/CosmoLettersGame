using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSwapMultiplayer : MonoBehaviour
{
  //  public string ScrabbleScreen; // The name of the scene you want to load

    public void SwapScreen()
    {
        Debug.Log("Clicked");
        // Convert char list to string
        List<char> charList = ColliderObject.inventory;
        Debug.Log(charList);

        List<char> charList2 = ColliderObject.inventory2;
        Debug.Log(charList2);



        SceneManager.LoadScene("Scrabble1Multiplayer", LoadSceneMode.Single);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSwap : MonoBehaviour
{
    public void SwapScreen()
    {
        SceneManager.LoadScene("ScrabbleGame", LoadSceneMode.Additive);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
*/
