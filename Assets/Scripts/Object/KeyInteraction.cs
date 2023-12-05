using UnityEngine;

public class KeyInteraction : MonoBehaviour
{

    private void OnTriggerEnter(Collider
        other) {
        if (other.gameObject.CompareTag("Player")) {
            Debug.Log("Info: get a key!");
            PlayerPrefs.SetInt("hasKey", 1);
            other.gameObject.GetComponent<PlayerStat>().setHasKey(1);
            Destroy(gameObject);
        }
    }

    public AudioClip getSound; // 파괴 시 재생할 사운드

    void OnDestroy()
    {
        if (getSound != null)
        {
            SoundManager.instance.PlaySound(getSound);
        }
    }
}
