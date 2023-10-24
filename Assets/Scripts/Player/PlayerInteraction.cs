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
            if (other.gameObject.CompareTag("Door")) {
                // TODO: Change The Scene
                Debug.Log("Info: Door opened");
                SceneManager.LoadScene(other.gameObject.name);
                // SceneManager.LoadScene("Room1");
            }

            // 2. Object Interaction
            if (other.gameObject.CompareTag("Object")) {
                Debug.Log("Info: Destroy the Object!");
                Destroy(other.gameObject);
            }

            // 3. Floor Interaction
            if (other.gameObject.CompareTag("Floor")) {
                // TODO: Change The Scene
                if (playerStat.getHasKey() == 1) {
                    Debug.Log("Info: Door opened");
                    playerStat.setHasKey(0);
                    PlayerPrefs.SetInt("hasKey", 0);
                    SceneManager.LoadScene(other.gameObject.name);
                }
                else {
                    Debug.Log("Info: Don't have a key.");
                }
            }
        }
    }
}
