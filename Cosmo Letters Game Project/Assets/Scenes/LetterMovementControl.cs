using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterMovementControl : MonoBehaviour
{
    public GameObject letterPrefab;
    public float generationInterval = 2f;
    public float letterSpeed = 5f;

    private void Start()
    {
        StartCoroutine(GenerateLetters());
    }

    private void Update()
    {
        MoveLetters();
    }

    private System.Collections.IEnumerator GenerateLetters()
    {
        while (true)
        {
            Instantiate(letterPrefab, GetRandomPosition(), Quaternion.identity);
            yield return new WaitForSeconds(generationInterval);
        }
    }

    private Vector3 GetRandomPosition()
    {
        float minX = -5f;
        float maxX = 5f;
        float minY = -3f;
        float maxY = 3f;

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        return new Vector3(randomX, randomY, 0f);
    }

    private void MoveLetters()
    {
        GameObject[] letters = GameObject.FindGameObjectsWithTag("Letter");

        foreach (GameObject letter in letters)
        {
            letter.transform.Translate(Vector3.down * letterSpeed * Time.deltaTime);

            // You can also use Rigidbody2D.velocity to move the letters instead:
            // letter.GetComponent<Rigidbody2D>().velocity = Vector2.down * letterSpeed;
        }
    }
}
