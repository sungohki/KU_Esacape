using UnityEngine;

public class BoxInteraction : MonoBehaviour
{
    public GameObject floorKey;
    public AudioClip brokesound;

    void ontriggerenter(Collider other) {
        if (other.CompareTag("weapon")) {
            Destroy(gameObject);
        }
    }
    private void OnDestroy()
    {
        if (brokesound != null)
        {
            SoundManager.instance.PlaySound(brokesound);
        }

        if (floorKey != null) {
            Instantiate(floorKey, transform.position, transform.rotation);
        }
    }
}
