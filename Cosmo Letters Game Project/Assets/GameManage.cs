using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    // Singleton instance
    private static GameManage instance;

    // User's name and selection variables
    private string userName;
    private Sprite userIconSelection;
    private List<char> userInventory;
    private float time;
    private string lod; //LevelOfDifficulty
    private int score;

    // Getter for the instance
    public static GameManage Instance 
    { 
        get 
        { 
            if (instance == null)
            {
                instance = new();
            }
            
            return instance; 
        } 
    }

    // Getter and setter for the user's name
    public string UserName { get { return userName; } set { userName = value; } }

    // Getter and setter for the user's selection
    public Sprite UserIconSelection { get { return userIconSelection; } set { userIconSelection = value; } }

    public List<char> UserInventory { get { return userInventory; } set { userInventory = value; } }

    public float Time { get { return time; } set { time = value; } }

    public string LOD{ get { return lod; } set { lod = value; } }

    public int Score { get { return score; } set { score = value; } }

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
