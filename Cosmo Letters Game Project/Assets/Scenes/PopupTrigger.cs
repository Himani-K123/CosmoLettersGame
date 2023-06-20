using UnityEngine;

public class PopupTrigger : MonoBehaviour
{
    public PopupMessageTMP popupMessage; // Reference to the PopupMessageTMP script

    public void ShowPopup()
    {
        popupMessage.ShowMessage("Hello, world!"); // Set the desired message here
    }
}

