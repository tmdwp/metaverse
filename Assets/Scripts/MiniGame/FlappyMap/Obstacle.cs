using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

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
    public Vector3 SetRandomPlace(Vector3 lastPosition, int obtacleCount)
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

    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerInFlappy player = collision.GetComponent<PlayerInFlappy>();

        if (player != null && !player.isDead)
            gameManager.AddScore(1);
    }
}
