using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

//Flappy Bird의 UI매니저
public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI mainTxt;
    public Image help;
    void Start()
    {
        if (mainTxt == null)
            Debug.LogError("restart text is null");
        if (scoreTxt == null)
            Debug.LogError("score text is null");
        if (help == null)
            Debug.LogError("Help Image is null");

        help.gameObject.SetActive(true);
        mainTxt.gameObject.SetActive(false);
    }

    public void SetEnd() //패배 Text 활성화
    {
        mainTxt.gameObject.SetActive(true);
    }

    public void UpdateScore(int score) //표시되는 점수 갱신
    {
        scoreTxt.text = score.ToString();
    }
}
