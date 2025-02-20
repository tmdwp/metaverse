using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//Ghost Hunt의 GameManager
public class GmHunt : MonoBehaviour
{
    public float currentScore = 0;

    ScoreManager scoreManager;
    UiHunt uiManager;
    public UiHunt UiHunt { get { return uiManager; } }
    private void Awake()
    {
        scoreManager = ScoreManager.Instance;
        uiManager = FindObjectOfType<UiHunt>();
    }
    private void Start() //UIManager에게 현재 점수(0점) 전달
    {
        uiManager.UpdateScore(0);
        Time.timeScale = 1f;
    }

    public void GameOver() //패배 시 UIManager의 패배 text 활성화 실행
    {
        uiManager.SetEnd();
    }

    public void EndGame() //ScoreManager에게 현재 점수 전달 및 메인 씬 이동
    {
        scoreManager.GetGhostHunt(currentScore);
        SceneManager.LoadScene("MainScene");
    }

    private void Update() // 현재 점수 = 생존한 시간
    {
        currentScore += Time.deltaTime;
        AddScore();
    }

    public void AddScore()
    {
        UiHunt.UpdateScore(currentScore);
    }


}