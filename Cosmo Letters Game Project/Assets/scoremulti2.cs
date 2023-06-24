using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoremulti2 : MonoBehaviour
{
    public TMP_Text messageText;
    public static int Score2; // Moved the declaration here

    // Start is called before the first frame update
    void Start()
    {
        Score2 = WordChecker.scoresecond;
    }

    // Update is called once per frame
    void Update()
    {
        Score2 = WordChecker.scoresecond;
        messageText.text = Score2.ToString();
    }
}

