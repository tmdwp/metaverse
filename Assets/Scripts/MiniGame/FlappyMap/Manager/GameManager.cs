using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Flappy Bird�� GameManager
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
    private void Start() // ���� text 0���� �ʱ�ȭ
    {
        uiManager.UpdateScore(0);
        Time.timeScale = 0f;
    }

    public void GameOver() //�й� �� �й� text Ȱ��ȭ ����
    {
        uiManager.SetEnd();
    }

    public void EndGame() //���� �� ���� ������ ScoreManager�� ����, ���� ������ �̵�
    {
        scoreManager.GetFlappyTop(currentScore);
        SceneManager.LoadScene("MainScene");
    }

    public void AddScore(int score) //���� ���� ���� �� text ����
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
    }
}
