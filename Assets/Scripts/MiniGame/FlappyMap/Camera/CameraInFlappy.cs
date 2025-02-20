using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Flappy Bird의 카메라
public class CameraInFlappy : MonoBehaviour
{
    public Transform target;
    float offsetX;

    // Start is called before the first frame update
    void Start() //플레이어와 카메라의 X축 위치의 차이값 계산
    {
        if (target == null)
            return;
        offsetX = transform.position.x - target.position.x;
    }

    // Update is called once per frame
    void Update() //Player의 일정 거리 뒤로 카메라 위치 갱신
    {
        if (target == null)
            return;
        Vector3 pos = transform.position;
        pos.x = target.position.x + offsetX;
        transform.position = pos;
    }
}
