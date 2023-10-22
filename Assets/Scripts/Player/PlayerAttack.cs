using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag != "Untagged")
            Debug.Log($"Sight Collision Occured : {other.gameObject.tag}");
    }
    private void OnTriggerStay(Collider other) {
        // Press Attack key 
        if (other.gameObject.CompareTag("NPC")) {
            if(Input.GetKey(KeyCode.Space)) {
                // TODO: Add Attack Motion

                // Destory NPC
                Destroy(other.gameObject);
            }
        }
    }

}
