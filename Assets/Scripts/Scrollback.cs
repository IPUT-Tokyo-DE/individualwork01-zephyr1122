using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrollback : MonoBehaviour
{
    public GameObject partner;  // �����̔w�i
    private float scrollSpeed = 0.01f;
    private float resetPositionX = -23f;  // �����͔w�i�̕��ɍ��킹��

    void Update()
    {
        transform.Translate(-scrollSpeed, 0, 0);

        // �������g��x������荶�ɍs������
        if (transform.position.x <= resetPositionX)
        {
            transform.position = new Vector3(partner.transform.position.x + 23f, 0, 10);
        }
    }
}



