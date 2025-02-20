using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ghost ����
public class Ghost : MonoBehaviour
{
    float speed = 10f;
    Rigidbody _rigidbody;


    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        if (_rigidbody == null)
            Debug.LogError("Not found RigidBody2D");
    }

    
    void Update() // ����
    {
        Vector3 velocity = _rigidbody.velocity;
        velocity.z = -speed;
        _rigidbody.velocity = velocity;
    }

    public void die() //��� �� ������Ʈ ����
    {
        Destroy(gameObject);
    }
}
