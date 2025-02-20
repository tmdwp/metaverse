using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//사격 메소드
public class GunAct : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float spawnDistance = 1f;
    // Start is called before the first frame update

    public void ShootBullet() //실행 시 총의 앞에 총알 생성
    {

        Vector3 spawnPosition = transform.position + transform.forward * spawnDistance;

        Quaternion spawnRotation = transform.rotation;

        Instantiate(bulletPrefab, spawnPosition, spawnRotation);
    }
}
