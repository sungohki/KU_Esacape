using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goose : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Weapon"))
        {
            // �÷��̾�� �浹�ϸ� Cat ������Ʈ�� �ı�
            Destroy(gameObject);
        }
    }
}
