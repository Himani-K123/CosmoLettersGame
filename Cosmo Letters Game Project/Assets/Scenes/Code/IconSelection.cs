using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IconSelection : MonoBehaviour
{
    public Sprite chosenIcon;

    public void SelectIcon(Image iconImage)
    {
        Debug.Log("SelectIcon called!");

        if (iconImage != null)
        {
            chosenIcon = iconImage.sprite;
            GameManage gameManage = GameManage.Instance;
            gameManage.UserIconSelection = chosenIcon;
            Debug.Log("Chosen Icon: " + chosenIcon.name);
            SceneManager.LoadScene("AgarGame", LoadSceneMode.Single);
        }
        else
        {
            Debug.LogWarning("Icon Image is null!");
        }
    }
}



