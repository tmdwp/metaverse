using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


//Ghost Hunt �̴ϰ����� UIManager
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

    public void SetEnd() //���� ���� �ؽ�Ʈ Ȱ��ȭ
    {
        EndTxt.gameObject.SetActive(true);
    }

    public void UpdateScore(float score) // ���� ���� ����
    {
        scoreTxt.text = score.ToString("F0");
    }
}
