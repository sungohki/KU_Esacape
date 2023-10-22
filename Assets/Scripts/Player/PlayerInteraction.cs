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
        // if (other.gameObject.tag == "Door") {
        //     // Testing
        //     door = GameObject.Find("Gate");
        //     door.GetComponent<Gate>().openDoor();
        // }

        if (Input.GetKey(KeyCode.Space)) {
            // 1. Door Interaction
            if (other.gameObject.tag == "Door") {
                // TODO: Change The Scene
                if (playerStat.getPlayerState() == true || true) {
                    Debug.Log("Info: Door opened");
                    // SceneManager.LoadScene(other.gameObject.name);
                    SceneManager.LoadScene("Room1");
                }
                else {
                    Debug.Log("Info: Don't have a key.");
                }
            }

            // 2. Key Interaction
            if (other.gameObject.CompareTag("Key")) {
                Debug.Log("Info: get a key!");
                playerStat.setPlayerState(true);
                Destroy(other.gameObject);
            }
        }
    }
}
