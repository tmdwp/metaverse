using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//최고 점수 보드
public class ScoreBoard : MonoBehaviour
{
    public TextMeshProUGUI huntTxt;
    public TextMeshProUGUI flappyTxt;
    int huntScore, flappyScore;
    // Update is called once per frame
    void Update()
    {
        //ScoreManager에게서 점수를 받아와 text 갱신
        huntScore = ScoreManager.Instance.SetHuntScore();
        flappyScore = ScoreManager.Instance.SetFlappyScore();

        huntTxt.text = huntScore.ToString();
        flappyTxt.text = flappyScore.ToString();
    }
}
