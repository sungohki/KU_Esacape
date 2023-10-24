using UnityEngine;

public class BoxInteraction : MonoBehaviour
{
    public GameObject floorKey;

    private void OnDestroy()
    {
        if (floorKey != null) {
            Instantiate(floorKey, transform.position, transform.rotation);
        }
    }
}
