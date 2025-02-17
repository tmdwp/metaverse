using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    private void Start()
    {
        uiManager.UpdateScore(0);
        Time.timeScale = 0f;
    }

    public void GameOver()
    {
        uiManager.SetRestart();
    }

    public void EndGame()
    {
        scoreManager.GetFlappyTop(currentScore);
        SceneManager.LoadScene("MainScene");
    }

    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
    }
}
