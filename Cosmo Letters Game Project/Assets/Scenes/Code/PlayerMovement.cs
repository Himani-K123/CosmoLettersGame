using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 500f; // Adjust the movement speed as needed
    private SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component
    private GameManage gameManage;

    public Sprite rocket; // Reference to the "rocket" sprite

    public bool arrowKeysActive;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component
        gameManage = GameManage.Instance;

        if (gameManage != null && gameManage.UserIconSelection != null)
        {
            spriteRenderer.sprite = gameManage.UserIconSelection;
        }
        else
        {
            spriteRenderer.sprite = rocket;
        }
    }

    void Update()
    {
        float horizontalInput = 0, verticalInput = 0;

    if (!arrowKeysActive)
    {
        if (Input.GetKey(KeyCode.W))
        {
            verticalInput += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            verticalInput -= 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            horizontalInput -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            horizontalInput += 1;
        }
    }
    else
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            verticalInput += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            verticalInput -= 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalInput -= 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontalInput += 1;
        }
    }

/*
        if (!arrowKeyActive)
        {
            if 
            {
                Input.GetKey(KeyCode.W)
                verticalInput += 1;
            }
            else
            {
                Input.GetKey(KeyCode.UpArrow)
                verticalInput += 1;
            }
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            verticalInput -= 1;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalInput -= 1;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            horizontalInput += 1;
        }
*/
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0) * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        ColliderObject letter = collision.gameObject.GetComponentInChildren<ColliderObject>();
        if (letter != null)
        {
            letter.RandomizeLetterAndLocation();
        }
    }
}