using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Flappy Bird�� ī�޶�
public class CameraInFlappy : MonoBehaviour
{
    public Transform target;
    float offsetX;

    // Start is called before the first frame update
    void Start() //�÷��̾�� ī�޶��� X�� ��ġ�� ���̰� ���
    {
        if (target == null)
            return;
        offsetX = transform.position.x - target.position.x;
    }

    // Update is called once per frame
    void Update() //Player�� ���� �Ÿ� �ڷ� ī�޶� ��ġ ����
    {
        if (target == null)
            return;
        Vector3 pos = transform.position;
        pos.x = target.position.x + offsetX;
        transform.position = pos;
    }
}
