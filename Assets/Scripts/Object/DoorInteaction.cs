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

    private void OnTriggerEnter(Collider other) {
        Debug.Log("enter!");
        if (other.gameObject.CompareTag("Player")) {
            door.GetComponent<DoorAction>().openDoor(other);
        }
    }
    private void OnTriggerExit(Collider other) {
        Debug.Log("exit!");
        if (other.gameObject.CompareTag("Player")) {
            door.GetComponent<DoorAction>().openDoor(other);
        }       
    }
}
