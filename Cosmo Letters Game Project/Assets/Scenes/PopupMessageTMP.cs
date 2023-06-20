using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopupMessageTMP : MonoBehaviour
{
    public TMP_Text messageText;
    public float displayDuration = 3f;

    private Coroutine displayCoroutine;

    public void ShowMessage(string message)
    {
        if (displayCoroutine != null)
            StopCoroutine(displayCoroutine);

        messageText.text = message;
        gameObject.SetActive(true);

        displayCoroutine = StartCoroutine(HideAfterDuration());
    }

    private IEnumerator HideAfterDuration()
    {
        yield return new WaitForSeconds(displayDuration);

        HideMessage();
    }

    public void HideMessage()
    {
        gameObject.SetActive(false);
    }
}
