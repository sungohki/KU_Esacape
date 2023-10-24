using UnityEngine;

public class KeyInteraction : MonoBehaviour
{

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Player")) {
            Debug.Log("Info: get a key!");
            PlayerPrefs.SetInt("hasKey", 1);
            other.gameObject.GetComponent<PlayerStat>().setHasKey(1);
            Destroy(gameObject);
        }
    }
}
