using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ghost Hunt�� �Ѿ�
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
    void Update() //�̵�
    {
        Vector3 velocity = _rigidbody.velocity;
        velocity.z = speed;
        _rigidbody.velocity = velocity;
    }

    private void OnTriggerEnter(Collider other) // �� �Ǵ� Ghost�� �浹 �� ������Ʈ ����
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
