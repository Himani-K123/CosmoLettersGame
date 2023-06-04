using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderObject : MonoBehaviour
{
    public char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    public static List<char> inventory = new List<char>();
    public float minX = -10f;
    public float maxX = 10f;
    public float minY = 0f;
    public float maxY = 5f;
    public float minZ = -5f;
    public float maxZ = 5f; 


    public void RandomizeLetterAndLocation()
    {
        TextMesh textMesh = GetComponent<TextMesh>();
        inventory.Add(char.Parse(textMesh.text));
        string output = "Inventory: " + string.Join(", ", inventory);
        Debug.Log(output);

        int randomIndex = Random.Range(0, letters.Length);
        char randomLetter = letters[randomIndex];
    
        // Update the letter object with the new letter
        textMesh.text = randomLetter.ToString();

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        float randomZ = Random.Range(minZ, maxZ);

        transform.position = new Vector3(randomX, randomY, randomZ);
    }
}
