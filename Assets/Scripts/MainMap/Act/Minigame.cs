using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

enum MinGame
{
    Flappy,
    GhostHunt
}

public class Minigame : MonoBehaviour
{
    public int minigameNm; //미니게임 구분
    bool colli = false; // 일점 벙위 내 플레이어 있는지 확인

    List<string> minigame = new List<string>();
    private void Start()
    { //미니게임 씬 이름 저장
        minigame.Add("Flappy");
        minigame.Add("GhostHunt");
    }
    private void Update()
    {
        if (colli) // 일정 범위 내 접근 시
        {
            if (Input.GetKeyDown(KeyCode.Space)) // 상호작용하면
            {
                SceneManager.LoadScene(minigame[minigameNm]); // 미니게임 시작
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) // 플레이어가 일정 범위내 접근 시
    {
        PlayerInMain player = collision.GetComponent<PlayerInMain>();
        if (player != null)  
        {
            colli = true; //충돌 여부 true 
        }
    }

    private void OnTriggerExit2D(Collider2D collision) // 플레이어가 멀어졌다면
    {
        PlayerInMain player = collision.GetComponent<PlayerInMain>();
        if (player != null)
        {
            colli = false; //충돌 여부 false
        }
    }

}
