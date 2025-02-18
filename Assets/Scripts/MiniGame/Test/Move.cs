using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float speed = 10f;
    Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        if (_rigidbody == null)
            Debug.LogError("Not found RigidBody2D");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = _rigidbody.velocity;
        velocity.z = -speed;
        _rigidbody.velocity = velocity;
    }
}
