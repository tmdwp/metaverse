using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI restartTxt;
    void Start()
    {
        if (restartTxt == null)
            Debug.LogError("restart text is null");
        if (scoreTxt == null)
            Debug.LogError("score text is null");

        restartTxt.gameObject.SetActive(false);
    }

    public void SetRestart()
    {
        restartTxt.gameObject.SetActive(true);
    }

    public void UpdateScore(int score)
    {
        scoreTxt.text = score.ToString();
    }
}
