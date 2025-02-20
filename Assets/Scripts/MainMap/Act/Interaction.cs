using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interaction : MonoBehaviour
{
    Animator animator; // 오브젝트의 상호작용 시 애니메이션
    bool colli = false; // 충돌 여부 확인
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && colli) // 일정 범위 내에서 상호작용했을 경우 애니메이션 실행
        {
            if (!animator.GetBool("Act"))
                animator.SetBool("Act", true);
            else animator.SetBool("Act", false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerInMain player = collision.GetComponent<PlayerInMain>(); // 충돌 순간 충돌여부 true
        if (player != null)
        {
            colli = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) // 충돌이 끝날 경우 여부 false
    {
        PlayerInMain player = collision.GetComponent<PlayerInMain>();
        if (player != null)
        {
            colli = false;
        }
    }
}
