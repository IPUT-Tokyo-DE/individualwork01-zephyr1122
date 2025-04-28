using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrollback : MonoBehaviour
{
    public GameObject partner;  // ‘Š•û‚Ì”wŒi
    private float scrollSpeed = 0.01f;
    private float resetPositionX = -23f;  // ‚±‚±‚Í”wŒi‚Ì•‚É‡‚í‚¹‚é

    void Update()
    {
        transform.Translate(-scrollSpeed, 0, 0);

        // ©•ª©g‚Ìx‚ªˆê’è‚æ‚è¶‚És‚Á‚½‚ç
        if (transform.position.x <= resetPositionX)
        {
            transform.position = new Vector3(partner.transform.position.x + 23f, 0, 10);
        }
    }
}



