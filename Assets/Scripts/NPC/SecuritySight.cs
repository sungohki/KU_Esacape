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
            // �÷��̾ �����ϸ� "Security" ������Ʈ�� �޽����� �����ϴ�.
            SendMessageUpwards("OnPlayerDetected");
        }
    }
}
