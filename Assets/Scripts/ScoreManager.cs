using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


//점수 관리자
public class ScoreManager : MonoBehaviour
{
    static ScoreManager scoreManager;
    public static ScoreManager Instance { get { return scoreManager; } }

    public float flappyScore = 0; //Flappy Bird의 최고 점수
    public float ghostScore = 0; //Ghost hunt의 최고 점수

    private void Awake()
    {
        //싱글톤화
        if(scoreManager != null && scoreManager != this)
        {
            Destroy(gameObject);
            return;
        }
        scoreManager = this;
        DontDestroyOnLoad(gameObject);

        if (PlayerPrefs.HasKey("FlappyScore"))
        {
            flappyScore = PlayerPrefs.GetFloat("FlappyScore");
        }
        if (PlayerPrefs.HasKey("GhostScore"))
        {
            ghostScore = PlayerPrefs.GetFloat("GhostScore");
        }
    }

    public void GetFlappyTop(int score) //FlappyBird의 최고 점수 저장
    {
        if (flappyScore < score)
        {
            flappyScore = score;
            PlayerPrefs.SetFloat("FlappyScore", flappyScore);
        }
    }

    public void GetGhostHunt(float score) //Ghost Hunt의 최고 점수 저장
    {
        if (ghostScore < score)
        {
            ghostScore = score;
            PlayerPrefs.SetFloat("GhostScore", ghostScore);
        }
    }

    public int SetFlappyScore() //Flappy Bird의 최고 점수 전달
    {   
        return (int)flappyScore;
    }
    public int SetHuntScore() //Ghost Hunt의 최고 점수 전달
    {
        return (int)ghostScore;
    }
}
