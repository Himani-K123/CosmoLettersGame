using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 500f; // Adjust the movement speed as needed

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0) * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }

    /*void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided"); 
        if (collision.gameObject.CompareTag("Letter"))
        {
            LetterObject letter = collision.gameObject.GetComponentInChildren<LetterObject>();
            if (letter != null)
            {
                letter.RandomizeLetterAndLocation();
            }
        }
    }*/
}


