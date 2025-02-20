using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Flappy Bird의 GameManager
public class GameManager : MonoBehaviour
{

    private int currentScore = 0;

    ScoreManager scoreManager;
    UIManager uiManager;
    public UIManager UIManager { get { return uiManager; } }
    private void Awake()
    {
        scoreManager = ScoreManager.Instance;
        uiManager = FindObjectOfType<UIManager>();
    }
    private void Start() // 점수 text 0으로 초기화
    {
        uiManager.UpdateScore(0);
        Time.timeScale = 0f;
    }

    public void GameOver() //패배 시 패배 text 활성화 실행
    {
        uiManager.SetEnd();
    }

    public void EndGame() //실행 시 현재 점수를 ScoreManager에 전달, 메인 씬으로 이동
    {
        scoreManager.GetFlappyTop(currentScore);
        SceneManager.LoadScene("MainScene");
    }

    public void AddScore(int score) //현재 점수 갱신 및 text 갱신
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
    }
}
