using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CompareMultiScores : MonoBehaviour
{
    public Score Score1;
    public scoremulti2 scoremulti2;
    public TMP_Text messageText;

    void Start()
    {

        if (Score.Score1 > scoremulti2.Score2)
        {
            messageText.text = ("PLAYER 1");
        }
        else if (scoremulti2.Score2 > Score.Score1)
        {
            messageText.text = ("PLAYER 2");
        }
        else
        {
            messageText.text = ("IT'S A TIE!");
        }
    }
}


