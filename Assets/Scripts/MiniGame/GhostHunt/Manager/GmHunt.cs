using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    private void Start()
    {
        uiManager.UpdateScore(0);
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        uiManager.SetEnd();
    }

    public void EndGame()
    {
        scoreManager.GetGhostHunt(currentScore);
        SceneManager.LoadScene("MainScene");
    }

    private void Update()
    {
        currentScore += Time.deltaTime;
        AddScore();
    }

    public void AddScore()
    {
        UiHunt.UpdateScore(currentScore);
    }


}