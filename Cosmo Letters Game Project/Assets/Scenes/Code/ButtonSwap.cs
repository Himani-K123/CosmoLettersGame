using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSwap : MonoBehaviour
{
  //  public string ScrabbleScreen; // The name of the scene you want to load

    public void SwapScreen()
    {
        // Convert char list to string
        List<char> charList = ColliderObject.inventory;
        string charListData = new string(charList.ToArray());
        GameManage gameManage = GameManage.Instance;
        gameManage.UserInventory = charListData;

        SceneManager.LoadScene("ScrabbleGame", LoadSceneMode.Additive);
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