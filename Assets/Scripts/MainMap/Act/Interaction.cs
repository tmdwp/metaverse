using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interaction : MonoBehaviour
{
    Animator animator; // ������Ʈ�� ��ȣ�ۿ� �� �ִϸ��̼�
    bool colli = false; // �浹 ���� Ȯ��
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && colli) // ���� ���� ������ ��ȣ�ۿ����� ��� �ִϸ��̼� ����
        {
            if (!animator.GetBool("Act"))
                animator.SetBool("Act", true);
            else animator.SetBool("Act", false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerInMain player = collision.GetComponent<PlayerInMain>(); // �浹 ���� �浹���� true
        if (player != null)
        {
            colli = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) // �浹�� ���� ��� ���� false
    {
        PlayerInMain player = collision.GetComponent<PlayerInMain>();
        if (player != null)
        {
            colli = false;
        }
    }
}
