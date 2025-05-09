using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrollback : MonoBehaviour
{
    public GameObject partner;  // 相方の背景
    private float scrollSpeed = 0.01f;
    private float resetPositionX = -23f;  // ここは背景の幅に合わせる

    void Update()
    {
        transform.Translate(-scrollSpeed, 0, 0);

        // 自分自身のxが一定より左に行ったら
        if (transform.position.x <= resetPositionX)
        {
            transform.position = new Vector3(partner.transform.position.x + 23f, 0, 10);
        }
    }
}



