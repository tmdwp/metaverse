using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ghost Hunt의 패배 조건 관리
public class PlayerWall : MonoBehaviour
{
    public GmHunt gameManager; //Ghost Hunt의 게임 매니저
    bool isDead = false; // 패배 여부

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isDead) // 사망 후 키 입력 시 메인씬으로 이동
        {
            Time.timeScale = 1f;
            gameManager.EndGame();
        }  
    }

    private void OnTriggerEnter(Collider other) // Ghost와 충돌 시 사망
    {
        if (other.CompareTag("Ghost"))
        {
            isDead = true;
            Time.timeScale = 0f;
            gameManager.GameOver();
        }
    }

    public bool IsDie() // 사망 여부 전달
    {
        return isDead;
    }
}
