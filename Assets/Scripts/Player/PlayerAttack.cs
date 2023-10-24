using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    GameObject player;

    private void Start() {
        player = GameObject.Find("Player");
    }
    private void OnTriggerEnter(Collider other) {
        // if (other.gameObject.tag != "Untagged")
        //     Debug.Log($"Sight Collision Occured : {other.gameObject.tag}");
    }
    private void OnTriggerStay(Collider other) {
        // Press Attack key 
        if (other.gameObject.CompareTag("NPC")) {
            if(Input.GetKey(KeyCode.Space)) {
                // TODO: Add Attack Motion

                // 1. Destory NPC
                Destroy(other.gameObject);
                // 2. Sound Occured
                player.GetComponent<PlayerMoving>().SoundOccur();
            }
        }
    }

}
