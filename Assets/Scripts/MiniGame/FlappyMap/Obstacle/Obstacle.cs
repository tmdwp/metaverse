using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

//Flappy Bird의 장애물
public class Obstacle : MonoBehaviour
{
    public float highPosY = 1f;
    public float lowPosY = -1f;

    public float holeSizeMax = 3f;
    public float holeSizeMin = 1f;

    public Transform topObject;
    public Transform bottomObject;

    public float widthPadding = 6f;

    public GameManager gameManager;

    private void Start()
    {
    }
    public Vector3 SetRandomPlace(Vector3 lastPosition, int obtacleCount) //일정 범위의 무작위 위치 전달
    {
        float holeSize = Random.Range(holeSizeMin, holeSizeMax);
        float halfHoleSize = holeSize / 2;

        topObject.localPosition = new Vector3(0, halfHoleSize+1f);
        bottomObject.localPosition = new Vector3(0, -halfHoleSize-0.5f);
        
        Vector3 placePosition = lastPosition + new Vector3(widthPadding, 0);
        placePosition.y = Random.Range(lowPosY, highPosY);

        transform.position = placePosition;

        return placePosition;
    }

    private void OnTriggerExit2D(Collider2D collision) //플레이어가 일정 영역을 벗어났을 경우 점수 증가
    {
        PlayerInFlappy player = collision.GetComponent<PlayerInFlappy>();

        if (player != null && !player.isDead)
            gameManager.AddScore(1);
    }
}
