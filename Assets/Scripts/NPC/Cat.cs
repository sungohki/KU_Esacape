using UnityEngine;

public class Cat : MonoBehaviour
{
    public AudioClip catAttackedSound; // 파괴 시 재생할 사운드

    void OnDestroy()
    {
        if (catAttackedSound != null)
        {
            SoundManager.instance.PlaySound(catAttackedSound);
        }
    }
}