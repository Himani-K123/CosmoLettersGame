using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterObject : MonoBehaviour
{
    public char[] letters;
    public Transform[] positions;
    private char currentLetter;
    private Transform currentTransform;

    private void Start()
    {
        SetRandomLetter();
    }

    public void SetRandomLetter()
    {
        int randomIndex = Random.Range(0, letters.Length);
        currentLetter = letters[randomIndex];

        int randomPosition = Random.Range(0, positions.Length);
        currentTransform = positions[randomPosition];

        transform.position = currentTransform.position;
        // Set the letter display based on currentLetter
    }   

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerIcon"))
        {
            SetRandomLetter();
        }
    }

}
