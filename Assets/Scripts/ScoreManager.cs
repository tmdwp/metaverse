using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    static ScoreManager scoreManager;
    public static ScoreManager Instance { get { return scoreManager; } }

    public float flappyScore = 0;
    public float ghostScore = 0;

    private void Awake()
    {
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

    public void GetFlappyTop(int score)
    {
        if (flappyScore < score)
        {
            flappyScore = score;
            PlayerPrefs.SetFloat("FlappyScore", flappyScore);
        }
    }

    public void GetGhostHunt(float score)
    {
        if (ghostScore < score)
        {
            ghostScore = score;
            PlayerPrefs.SetFloat("GhostScore", ghostScore);
        }
    }

    public int SetFlappyScore()
    {   
        return (int)flappyScore;
    }
    public int SetHuntScore()
    {
        return (int)ghostScore;
    }
}
