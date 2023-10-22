using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    PlayerStat playerStat;

    GameObject door;

    private void Start() {
        playerStat = GameObject.FindAnyObjectByType<PlayerStat>();
    }
    private void OnTriggerStay(Collider other) {
        if (Input.GetKey(KeyCode.Space)) {
            // // Testing
            // door = GameObject.Find("Gate");
            // door.GetComponent<Gate>().openDoor();

            // 1. Door Interaction
            if (other.gameObject.tag == "Door") {
                // TODO: Change The Scene
                if (playerStat.getPlayerState() == true) {
                    Debug.Log("Info: Door opened");
                    SceneManager.LoadScene(other.gameObject.name);
                }
                else {
                    Debug.Log("Info: Don't have a key.");
                }
            }

            // 2. Key Interaction
            if (other.gameObject.CompareTag("Key")) {
                playerStat.setPlayerState(true);
                Destroy(other);
            }
        }
    }
}
