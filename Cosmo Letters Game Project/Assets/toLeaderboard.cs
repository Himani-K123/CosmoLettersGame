using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toLeaderboard : MonoBehaviour
{
    public void leaderboardScreen()
    {
        SceneManager.LoadScene("Leaderboard", LoadSceneMode.Additive);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
