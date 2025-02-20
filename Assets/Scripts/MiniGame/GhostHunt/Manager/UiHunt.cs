using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


//Ghost Hunt 미니게임의 UIManager
public class UiHunt : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI EndTxt;

    void Start()
    {
        if (EndTxt == null)
            Debug.LogError("restart text is null");
        if (scoreTxt == null)
            Debug.LogError("score text is null");
        EndTxt.gameObject.SetActive(false);
    }

    public void SetEnd() //게임 오버 텍스트 활성화
    {
        EndTxt.gameObject.SetActive(true);
    }

    public void UpdateScore(float score) // 현재 점수 갱신
    {
        scoreTxt.text = score.ToString("F0");
    }
}
