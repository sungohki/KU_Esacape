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
            // 플레이어와 충돌하면 Cat 오브젝트를 파괴
            Destroy(gameObject);
        }
    }

    public AudioClip gooseAttackedSound; // 파괴 시 재생할 사운드

    void OnDestroy()
    {
        if (gooseAttackedSound != null)
        {
            SoundManager.instance.PlaySound(gooseAttackedSound);
        }
    }
}
