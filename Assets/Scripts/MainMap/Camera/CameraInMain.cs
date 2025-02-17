using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
