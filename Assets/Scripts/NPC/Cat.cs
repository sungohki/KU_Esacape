using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Weapon"))
        {
            // �÷��̾�� �浹�ϸ� Cat ������Ʈ�� �ı�
            Destroy(gameObject);
        }
    }
}
