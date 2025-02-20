using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//Ghost Hunt�� GameManager
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
    private void Start() //UIManager���� ���� ����(0��) ����
    {
        uiManager.UpdateScore(0);
        Time.timeScale = 1f;
    }

    public void GameOver() //�й� �� UIManager�� �й� text Ȱ��ȭ ����
    {
        uiManager.SetEnd();
    }

    public void EndGame() //ScoreManager���� ���� ���� ���� �� ���� �� �̵�
    {
        scoreManager.GetGhostHunt(currentScore);
        SceneManager.LoadScene("MainScene");
    }

    private void Update() // ���� ���� = ������ �ð�
    {
        currentScore += Time.deltaTime;
        AddScore();
    }

    public void AddScore()
    {
        UiHunt.UpdateScore(currentScore);
    }


}