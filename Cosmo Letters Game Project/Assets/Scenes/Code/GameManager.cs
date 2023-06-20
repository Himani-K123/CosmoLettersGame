using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton instance
    private static GameManager instance;

    // User's name and selection variables
    private string userName;
    private Sprite userIconSelection; // Changed data type to Sprite
    private float time;
    private string userInventory;

    // Getter for the instance
    public static GameManager Instance { get { return instance; } }

    // Getter and setter for the user's name
    public string UserName { get { return userName; } set { userName = value; } }

    // Getter and setter for the user's selection
    public Sprite UserIconSelection { get { return userIconSelection; } set { userIconSelection = value; } } // Changed data type to Sprite

    public float Time { get { return time; } set { time = value; } }

    public string UserInventory { get { return userInventory; } set { userInventory = value; } }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
