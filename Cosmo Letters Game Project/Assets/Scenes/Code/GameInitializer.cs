using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInitializer : MonoBehaviour
{
    private void Start()
    {
        SceneManager.LoadScene("PersistentScene", LoadSceneMode.Additive);
        // Load other scenes as needed
    }
}

