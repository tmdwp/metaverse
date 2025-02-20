using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInFlappy : MonoBehaviour
{
    Animator animator;
    Rigidbody2D _rigidbody;

    public float flapForce = 6f; // flap 시 적용할 힘
    public float forwardSpeed = 3f; // 전진 속도
    public bool isDead = false; // 사망 여부
    float deathCooldown = 0f; // 사망 시 대기 시간

    bool isFlap = false; // flap 여부

    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponentInChildren<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();

        if (animator == null)
            Debug.LogError("Not found Animator");

        if (_rigidbody == null)
            Debug.LogError("Not found RigidBody2D");
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead) //사망시
        {
            if (deathCooldown <= 0) //사망대기시간이 0 미만이면
            {
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) // 조작 시 미니게임 종료 후 메인 이동
                {
                    gameManager.EndGame();
                }
            }
            else
            {
                deathCooldown -= Time.deltaTime; // 사망대기시간 감소
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) // 사망하지 않고 조작 시
            {
                isFlap = true; // flap
            }
        }
    }
    private void FixedUpdate() //flap 시 이동
    {
        if (isDead) return;

        Vector3 velocity = _rigidbody.velocity;
        velocity.x = forwardSpeed;

        if (isFlap)
        {
            velocity.y += flapForce;
            isFlap = false;
        }
        _rigidbody.velocity = velocity;
        float angle = Mathf.Clamp((_rigidbody.velocity.y * 2f), -30, 10);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    private void OnCollisionEnter2D(Collision2D collision) // 장애물과 충돌 시 게임 오버(사망)
    {
        if (isDead) return;

        isDead = true;
        deathCooldown = 1f;

        //animator.SetBool("isDie", true);
        gameManager.GameOver();
    }
}
