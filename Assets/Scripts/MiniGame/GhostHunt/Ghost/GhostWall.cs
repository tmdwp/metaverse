using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ghost�� �����ϴ� ��
public class GhostWall : MonoBehaviour
{
    public GameObject ghostPrefab;
    public float spawnDistance = -2f;
    public PlayerWall wall;

    Vector3 spawnPosition; //��Ʈ ���� ��ġ
    Quaternion spawnRotation; //��Ʈ ���� �� ȸ��
    // Start is called before the first frame update
    void Start() // ���� ��ġ �� ȸ�� ����
    {
        spawnPosition = transform.position;
        spawnPosition.z -= 2;
        spawnRotation = transform.rotation;
        InvokeRepeating("CreateGhost", 0, 1f); //�ֱ������� Ghost ���� �޼ҵ� ����
    }

    public void CreateGhost() //Ghost ����
    {
        if (!wall.IsDie()) //�÷��̾ �й����� ���� ���¶�� Ghost ����
        {
            spawnPosition.x = Random.Range(-15, 15);
            Instantiate(ghostPrefab, spawnPosition, spawnRotation);
        }
    }
}
