using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyNpc : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // �浹�� ������Ʈ�� NPC �±׸� ������ �ִٸ�
        if (other.CompareTag("NPC")) {
            // �浹�� ������Ʈ�� �ı�
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Object")) {
            Destroy(other.gameObject);
        }
    }

}
