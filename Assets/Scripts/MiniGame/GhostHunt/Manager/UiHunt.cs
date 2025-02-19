using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UiHunt : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI mainTxt;
//    public Image help;
    void Start()
    {
        if (mainTxt == null)
            Debug.LogError("restart text is null");
        if (scoreTxt == null)
            Debug.LogError("score text is null");
 //       if (help == null)
 //           Debug.LogError("Help Image is null");

 //       help.gameObject.SetActive(true);
        mainTxt.gameObject.SetActive(false);
    }

    public void SetEnd()
    {
        mainTxt.gameObject.SetActive(true);
    }

    public void UpdateScore(float score)
    {
        scoreTxt.text = score.ToString("F0");
    }
}
