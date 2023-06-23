using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 500f; // Adjust the movement speed as needed
    private SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component
    private GameManage gameManage;

    public Sprite rocket; // Reference to the "rocket" sprite

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
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

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