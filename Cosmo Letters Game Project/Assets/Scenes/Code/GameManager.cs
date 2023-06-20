using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    // Singleton instance
    private static GameManager instance;

    // User's name and selection variables
    private string userName;
    private Sprite userIconSelection;
    private float time;
    private string userInventory;

    // Leaderboard variables
    private List<string> leaderboard;

    // Getter for the instance
    public static GameManager Instance { get { return instance; } }

    // Getter and setter for the user's name
    public string UserName { get { return userName; } set { userName = value; } }

    // Getter and setter for the user's selection
    public Sprite UserIconSelection { get { return userIconSelection; } set { userIconSelection = value; } }

    public float Time { get { return time; } set { time = value; } }

    public string UserInventory { get { return userInventory; } set { userInventory = value; } }

    // Getter for the leaderboard
    public List<string> Leaderboard { get { return leaderboard; } }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);

        leaderboard = new List<string>();
    }
}
