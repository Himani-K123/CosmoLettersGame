using UnityEngine;

public class GameManage : MonoBehaviour
{
    // Singleton instance
    private static GameManage instance;

    // User's name and selection variables
    private string userName;
    private Sprite userIconSelection;
    private string userInventory;
    private float time;
    private string lod; //LevelOfDifficulty

    // Getter for the instance
    public static GameManage Instance { get { return instance; } }

    // Getter and setter for the user's name
    public string UserName { get { return userName; } set { userName = value; } }

    // Getter and setter for the user's selection
    public Sprite UserIconSelection { get { return userIconSelection; } set { userIconSelection = value; } }

    public string UserInventory { get { return userInventory; } set { userInventory = value; } }

    public float Time { get { return time; } set { time = value; } }

    public string LOD{ get { return lod; } set { lod = value; } }

    private void Awake()
{
    Debug.Log("GameManage Awake");

    if (instance != null && instance != this)
    {
        Destroy(this.gameObject);
        return;
    }

    instance = this;
    DontDestroyOnLoad(this.gameObject);
}

}
