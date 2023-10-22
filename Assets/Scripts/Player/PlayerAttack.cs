using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        Debug.Log($"Sight Collision Occured : {other.gameObject.name}");
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
