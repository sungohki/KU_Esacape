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
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            door.GetComponent<DoorAction>().openDoor();
        }
    }
    private void OnTriggerExit(Collider other) {
        Debug.Log("exit!");
        if (other.gameObject.CompareTag("Player")) {
            door.GetComponent<DoorAction>().closeDoor();
        }       
    }
}
