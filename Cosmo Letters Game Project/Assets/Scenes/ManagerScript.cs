using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    public GameObject letterPrefab;

    // Start is called before the first frame update
    void Start()
    {
        SpawnLetter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnLetter()
    {
        // Define the area where the letter objects will spawn
        Vector3 spawnAreaCenter = transform.position;  // Center position of the spawn area
        float spawnAreaRadius = 5f;  // Radius of the spawn area

        // Calculate a random position within the defined area
        Vector3 randomPosition = spawnAreaCenter + Random.insideUnitSphere * spawnAreaRadius;

        // Instantiate the letter prefab at the random position
        Instantiate(letterPrefab, randomPosition, Quaternion.identity);
    }

}
