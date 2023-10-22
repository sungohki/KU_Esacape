using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    GameObject door;

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Door") {
            // 1. Door Interaction
            if (Input.GetKey(KeyCode.F)) {
                // // TODO: Change The Scene
                // SceneManager.LoadScene(other.gameObject.name);
            }
            // Testing
            door = GameObject.Find("Gate");
            GetComponent<Gate>().openDoor();
        }
    }
}
