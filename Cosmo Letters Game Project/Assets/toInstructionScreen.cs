using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toInstructionScreen : MonoBehaviour
{
    public void toInstruction()
    {
        SceneManager.LoadScene("InstructionScreen", LoadSceneMode.Additive);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
