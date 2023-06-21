using UnityEngine;
using UnityEngine.UI;

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
        }
        else
        {
            Debug.LogWarning("Icon Image is null!");
        }
    }
}



