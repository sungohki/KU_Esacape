using UnityEngine;

public class Cat : MonoBehaviour
{
    public AudioClip catAttackedSound; // 파괴 시 재생할 사운드

    void OnDestroy()
    {
        if (catAttackedSound != null)
        {
            GameObject soundObject = new GameObject("CatAttackedSound"); // 새로운 GameObject 생성
            AudioSource audioSource = soundObject.AddComponent<AudioSource>(); // AudioSource 추가

            // AudioSource에 사운드 할당
            audioSource.clip = catAttackedSound;

            // 사운드 재생
            audioSource.Play();

            // 재생이 끝난 후 GameObject 파괴
            Destroy(soundObject, catAttackedSound.length);
        }
    }
}