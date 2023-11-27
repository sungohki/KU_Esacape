using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyNpc : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // 충돌한 오브젝트가 NPC 태그를 가지고 있다면
        if (other.CompareTag("NPC"))
        {
            // 충돌한 오브젝트를 파괴
            Destroy(other.gameObject);
        }
    }

}
