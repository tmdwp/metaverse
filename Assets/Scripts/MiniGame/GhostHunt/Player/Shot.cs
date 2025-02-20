using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//Ghost Hunt의 플레이어 조작
public class Shot : MonoBehaviour
{
    public float moveSpeed = 5f;
    Rigidbody _rigidbody;
    Animator animator;
    GunAct gun; // 총 오브젝트의 메소드

    bool isShot = false; //사격 했는지 여부

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
        //플레이어 이동
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


        // 사격 메소드
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (isShot == false)
            {
                animator.SetTrigger("Shot");
                gun.ShootBullet(); //gun 메소드의 총알 생성 실행
                isShot = true;
                StartCoroutine(Cool()); //사격 쿨타임 적용
            }
        }
    }
    IEnumerator Cool() //사격 쿨타임
    {
        yield return new WaitForSeconds(0.3f);
        isShot = false;
    }


}
