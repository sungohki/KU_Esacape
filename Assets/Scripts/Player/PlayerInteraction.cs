using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private void OnCollisionStay(Collision other) {
        if (other.gameObject.tag == "door") {
            if (Input.GetKey(KeyCode.F)) {
                // TODO: Change The Scene
            }
        }
    }
}
