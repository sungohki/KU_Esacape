using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    PlayerStat playerStat;

    private void Start() {
        playerStat = GameObject.FindAnyObjectByType<PlayerStat>();
    }
    private void OnTriggerStay(Collider other) {

        // Interaction Key : KeyCode.Space
        if (Input.GetKey(KeyCode.Space)) {
            // 1. Door Interaction
            if (other.gameObject.tag == "Door") {
                // TODO: Change The Scene
                if (playerStat.getHasKey() == true || true) {
                    Debug.Log("Info: Door opened");
                    // SceneManager.LoadScene(other.gameObject.name);
                    SceneManager.LoadScene("Room1");
                }
                else {
                    Debug.Log("Info: Don't have a key.");
                }
            }

            // 2. Object Interaction
            if (other.gameObject.CompareTag("Object")) {
                Debug.Log("Info: Destroy the Object!");
                Destroy(other.gameObject);
            }
        }
    }
}
