using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    string destination;

    private void OnCollisionStay(Collision other) {
        if (other.gameObject.tag == "Door") {
            if (Input.GetKey(KeyCode.F)) {
                // TODO: Change The Scene
                SceneManager.LoadScene(other.gameObject.name);
            }
        }
    }
}
