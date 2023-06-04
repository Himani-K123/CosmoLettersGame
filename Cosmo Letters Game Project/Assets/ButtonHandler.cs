using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public InputHandler inputHandler;

    public void OnButtonClick()
    {
        inputHandler.HandleInput();
    }
}
