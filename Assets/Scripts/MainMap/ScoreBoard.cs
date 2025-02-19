using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreBoard : MonoBehaviour
{
    public TextMeshProUGUI huntTxt;
    public TextMeshProUGUI flappyTxt;
    int huntScore, flappyScore;
    // Update is called once per frame
    void Update()
    {
        huntScore = ScoreManager.Instance.SetHuntScore();
        flappyScore = ScoreManager.Instance.SetFlappyScore();

        huntTxt.text = huntScore.ToString();
        flappyTxt.text = flappyScore.ToString();
    }
}
