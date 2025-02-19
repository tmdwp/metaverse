using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWall : MonoBehaviour
{
    public GmHunt gameManager;
    bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isDead)
        {
            Time.timeScale = 1f;
            gameManager.EndGame();
        }  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ghost"))
        {
            isDead = true;
            Time.timeScale = 0f;
            gameManager.GameOver();
        }
    }

    public bool IsDie()
    {
        return isDead;
    }
}
