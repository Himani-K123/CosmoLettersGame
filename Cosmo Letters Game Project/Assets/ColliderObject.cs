using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderObject : MonoBehaviour
{
    public char[] letters = { 'A', 'B', 'C', 'D', 'E' }; // Array of letters

    public void RandomizeLetterAndLocation()
    {
        Debug.Log("Randomize"); 
        int randomIndex = Random.Range(0, letters.Length);
        char randomLetter = letters[randomIndex];
    
        // Update the letter object with the new letter
        TextMesh textMesh = GetComponent<TextMesh>();
        textMesh.text = randomLetter.ToString();
    }
}
