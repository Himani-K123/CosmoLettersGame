using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text messageText;
    public static int Score1; // Moved the declaration here

    // Start is called before the first frame update
    void Start()
    {
        Score1 = WordChecker.score;
    }

    // Update is called once per frame
    void Update()
    {
        Score1 = WordChecker.score;
        messageText.text = "Score:" + Score1;
    }
}

