using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ghost 관리
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

    
    void Update() // 전진
    {
        Vector3 velocity = _rigidbody.velocity;
        velocity.z = -speed;
        _rigidbody.velocity = velocity;
    }

    public void die() //사망 시 오브젝트 삭제
    {
        Destroy(gameObject);
    }
}
