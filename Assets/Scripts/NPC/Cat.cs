using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Weapon"))
        {
            // 플레이어와 충돌하면 Cat 오브젝트를 파괴
            Destroy(gameObject);
        }
    }
}
