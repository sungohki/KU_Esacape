using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGoDown : MonoBehaviour
{
    public PlayerStat playerstat;
    string currentSceneName;
    string nextSceneName;

    private void Start() {
        playerstat = GetComponent<PlayerStat>();
        currentSceneName = SceneManager.GetActiveScene().name;
        if (currentSceneName == "Tutorial")
            nextSceneName = "Floor_3";
        else if (currentSceneName == "Floor_3")
            nextSceneName = "Floor_2";
        else if (currentSceneName == "Floor_2")
            nextSceneName = "Floor_1";
        else if (currentSceneName == "Floor_1")
            nextSceneName = "Exit";
        
        if (!playerstat)
            Debug.Log("playerstat not found");
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Door") && playerstat.getHasKey() == 1)
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
