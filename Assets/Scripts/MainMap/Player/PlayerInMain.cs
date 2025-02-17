using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum direction
{
    Up, Down, Left, Right
}

public class PlayerInMain : MonoBehaviour
{
    Vector3 move;
    SpriteRenderer spriteRenderer;
    public Sprite[] sprite = new Sprite[4];
    public float speed = 0.5f;

    // Update is called once per frame

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            move = transform.position;
            move.y += speed;
            transform.position = move;
            spriteRenderer.sprite = sprite[(int)direction.Up];

        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            move = transform.position;
            move.y -= speed;
            transform.position = move;
            spriteRenderer.sprite = sprite[(int)direction.Down];
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            move = transform.position;
            move.x -= speed;
            transform.position = move;
            spriteRenderer.sprite = sprite[(int)direction.Left];
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            move = transform.position;
            move.x += speed;
            transform.position = move;
            spriteRenderer.sprite = sprite[(int)direction.Right];
        }
    }
}
