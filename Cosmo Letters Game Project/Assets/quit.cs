using UnityEngine;
using System.Collections;

// Quits the player when the user presses the button

public class quit : MonoBehaviour
{
    public void GameQuit()
    {
        Application.Quit();
    }
}