using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecuritySight : MonoBehaviour
{
    public bool playerDetected = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !playerDetected)
        {
            playerDetected = true;
            // 플레이어를 감지하면 "Security" 오브젝트에 메시지를 보냅니다.
            SendMessageUpwards("OnPlayerDetected");
        }
    }
}
