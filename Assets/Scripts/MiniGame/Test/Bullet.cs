using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    void Update()
    {
        Vector3 velocity = _rigidbody.velocity;
        velocity.z = speed;
        _rigidbody.velocity = velocity;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }

        Move enemy = other.GetComponent<Move>();
        if(enemy != null) 
        {
            other.gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
