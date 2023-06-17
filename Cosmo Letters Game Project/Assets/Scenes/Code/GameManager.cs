using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton instance
    private static GameManager instance;

    // User's name and selection variables
    private string userName;
    private string userIconSelection;
    private int time;

    // Getter for the instance
    public static GameManager Instance { get { return instance; } }

    // Getter and setter for the user's name
    public string UserName { get { return userName; } set { userName = value; } }

    // Getter and setter for the user's selection
    public string UserSelection { get { return userIconSelection; } set { userIconSelection = value; } }

    public int Time { get { return time; } set { time = value; } }

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
