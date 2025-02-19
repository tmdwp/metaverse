using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAct : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float spawnDistance = 1f;
    // Start is called before the first frame update

    public void ShootBullet()
    {

        Vector3 spawnPosition = transform.position + transform.forward * spawnDistance;

        Quaternion spawnRotation = transform.rotation;

        Instantiate(bulletPrefab, spawnPosition, spawnRotation);
    }
}
