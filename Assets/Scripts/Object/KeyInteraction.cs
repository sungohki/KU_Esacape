using UnityEngine;

public class KeyInteraction : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Player")) {
            Debug.Log("Info: get a key!");
            other.gameObject.GetComponent<PlayerStat>().setHasKey(true);
            Destroy(gameObject);
        }
    }
}
