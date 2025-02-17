using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    static ScoreManager scoreManager;
    public static ScoreManager Instance { get { return scoreManager; } }

    public int flappyScore = 0;
    private void Awake()
    {
        if(scoreManager != null && scoreManager != this)
        {
            Destroy(gameObject);
            return;
        }
        scoreManager = this;
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetFlappyTop(int score)
    {
        if(flappyScore < score)
            flappyScore = score;
    }
}
