using UnityEngine;

public class DoorInteaction : MonoBehaviour
{
    Transform door;

    private void Start() {
        door = transform.parent;
        if (door == null) {
            Debug.LogWarning($"Error: {gameObject.name}'s parent gameObject is not found");
        }

    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            // 1. set 'door'
            door.GetComponent<DoorAction>().openDoor();
        }
    }
}
