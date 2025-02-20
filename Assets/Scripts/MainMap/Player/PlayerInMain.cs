using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

enum direction
{
    Up, Down, Left, Right
}


//메인에서의 플레이어 조작
public class PlayerInMain : MonoBehaviour
{
    Vector3 move;
    SpriteRenderer spriteRenderer;
    Rigidbody2D _rigidbody;
 

    public Sprite[] sprite = new Sprite[4];
    public float speed = 3f;

    // Update is called once per frame

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
   
        if(spriteRenderer == null)
        {
            Debug.LogError("Not Founded SpriteRenderer");
        }
        if (_rigidbody == null)
        {
            Debug.LogError("Not Founded Rigidbody");
        }
    }
    void Update()
    {
        //플레이어 이동
        Vector3 velocity = _rigidbody.velocity;
        velocity.x = 0;
        velocity.y = 0;
        _rigidbody.velocity = velocity;
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            velocity.y = speed;
            _rigidbody.velocity = velocity;
            spriteRenderer.sprite = sprite[(int)direction.Up];

        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            velocity.y = -speed;
            _rigidbody.velocity = velocity;
            spriteRenderer.sprite = sprite[(int)direction.Down];
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            velocity.x = -speed;
            _rigidbody.velocity = velocity;
            spriteRenderer.sprite = sprite[(int)direction.Left];
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            velocity.x = speed;
            _rigidbody.velocity = velocity;
            spriteRenderer.sprite = sprite[(int)direction.Right];
        }
    }

}
