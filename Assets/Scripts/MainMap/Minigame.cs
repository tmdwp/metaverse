using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

enum MinGame
{
    Flappy
}

public class Minigame : MonoBehaviour
{
    public int minigameNm; //�̴ϰ��� ����
    bool colli = false; // ���� ���� �� �÷��̾� �ִ��� Ȯ��

    List<string> minigame = new List<string>
    {
        "Flappy"
    };

    private void Update()
    {
        if (colli)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                SceneManager.LoadScene(minigame[minigameNm]);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerInMain player = collision.GetComponent<PlayerInMain>();
        if (player != null) 
        {
            colli = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerInMain player = collision.GetComponent<PlayerInMain>();
        if (player != null)
        {
            colli = false;
        }
    }

}
