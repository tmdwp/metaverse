using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostWall : MonoBehaviour
{
    public GameObject ghostPrefab;
    public float spawnDistance = -2f;
    Vector3 spawnPosition;
    Quaternion spawnRotation;
    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = transform.position;
        spawnPosition.z -= 2;
        spawnRotation = transform.rotation;
        InvokeRepeating("CreateGhost", 0, 1f);
    }

    public void CreateGhost()
    {
        spawnPosition.x = Random.Range(-15, 15);
        Instantiate(ghostPrefab, spawnPosition, spawnRotation);
    }
}
