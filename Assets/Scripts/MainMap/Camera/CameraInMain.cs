using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Main씬의 카메라
//플레이어를 중심으로 두고 카메라 이동
public class CameraInMain : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;
        Vector3 pos = transform.position;
        pos.x= target.position.x;
        pos.y = target.position.y;
        transform.position = pos;
    }
}
