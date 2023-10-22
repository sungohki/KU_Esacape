using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private void OnCollisionStay(Collision other) {
        // Press Attack key 
        if(Input.GetKey(KeyCode.Space)) {
            // TODO: Add Attack Motion

            // Destory NPC
            Destroy(other.gameObject);
        }
    }

}
