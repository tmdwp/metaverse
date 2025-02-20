using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ghost Hunt의 총알
public class Bullet : MonoBehaviour
{
    float speed = 20f;
    Rigidbody _rigidbody;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        if (_rigidbody == null)
        {
            Debug.LogError("Not Founded Rigidbody");
        }
    }
    void Update() //이동
    {
        Vector3 velocity = _rigidbody.velocity;
        velocity.z = speed;
        _rigidbody.velocity = velocity;
    }

    private void OnTriggerEnter(Collider other) // 벽 또는 Ghost와 충돌 시 오브젝트 제거
    {
        if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }

        Ghost enemy = other.GetComponent<Ghost>();
        if(enemy != null) 
        {
            enemy.die(); 
            Destroy(gameObject);
        }
    }
}
