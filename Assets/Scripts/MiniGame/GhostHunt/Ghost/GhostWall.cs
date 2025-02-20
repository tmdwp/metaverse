using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ghost를 생성하는 벽
public class GhostWall : MonoBehaviour
{
    public GameObject ghostPrefab;
    public float spawnDistance = -2f;
    public PlayerWall wall;

    Vector3 spawnPosition; //고스트 생성 위치
    Quaternion spawnRotation; //고스트 생성 시 회전
    // Start is called before the first frame update
    void Start() // 생성 위치 및 회전 설정
    {
        spawnPosition = transform.position;
        spawnPosition.z -= 2;
        spawnRotation = transform.rotation;
        InvokeRepeating("CreateGhost", 0, 1f); //주기적으로 Ghost 생성 메소드 실행
    }

    public void CreateGhost() //Ghost 생성
    {
        if (!wall.IsDie()) //플레이어가 패배하지 않은 상태라면 Ghost 생성
        {
            spawnPosition.x = Random.Range(-15, 15);
            Instantiate(ghostPrefab, spawnPosition, spawnRotation);
        }
    }
}
