using UnityEngine;

public class BoxInteraction : MonoBehaviour
{
    public GameObject floorKey;

    // void OnTriggerEnter(Collider other) {
        // if (other.CompareTag("weapon")) {
            // Destroy(gameObject);
        // }
    // }
    private void OnDestroy()
    {
        if (floorKey != null) {
            Instantiate(floorKey, transform.position, transform.rotation);
        }
    }
}
