using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//Ghost Hunt�� �÷��̾� ����
public class Shot : MonoBehaviour
{
    public float moveSpeed = 5f;
    Rigidbody _rigidbody;
    Animator animator;
    GunAct gun; // �� ������Ʈ�� �޼ҵ�

    bool isShot = false; //��� �ߴ��� ����

    void Start()
    {
        gun = GetComponentInChildren<GunAct>();
        animator = GetComponentInChildren<Animator>();
        _rigidbody = GetComponent<Rigidbody>();
        if (_rigidbody == null)
        {
            Debug.LogError("Not Founded Rigidbody");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //�÷��̾� �̵�
        Vector3 velocity = _rigidbody.velocity;
        velocity.x = 0;
        velocity.y = 0;
        _rigidbody.velocity = velocity;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            velocity.x = -moveSpeed;
            _rigidbody.velocity = velocity;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            velocity.x = moveSpeed;
            _rigidbody.velocity = velocity;
        }


        // ��� �޼ҵ�
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (isShot == false)
            {
                animator.SetTrigger("Shot");
                gun.ShootBullet(); //gun �޼ҵ��� �Ѿ� ���� ����
                isShot = true;
                StartCoroutine(Cool()); //��� ��Ÿ�� ����
            }
        }
    }
    IEnumerator Cool() //��� ��Ÿ��
    {
        yield return new WaitForSeconds(0.3f);
        isShot = false;
    }


}
