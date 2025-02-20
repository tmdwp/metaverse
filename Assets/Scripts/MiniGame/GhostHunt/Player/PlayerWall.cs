using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ghost Hunt�� �й� ���� ����
public class PlayerWall : MonoBehaviour
{
    public GmHunt gameManager; //Ghost Hunt�� ���� �Ŵ���
    bool isDead = false; // �й� ����

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isDead) // ��� �� Ű �Է� �� ���ξ����� �̵�
        {
            Time.timeScale = 1f;
            gameManager.EndGame();
        }  
    }

    private void OnTriggerEnter(Collider other) // Ghost�� �浹 �� ���
    {
        if (other.CompareTag("Ghost"))
        {
            isDead = true;
            Time.timeScale = 0f;
            gameManager.GameOver();
        }
    }

    public bool IsDie() // ��� ���� ����
    {
        return isDead;
    }
}
