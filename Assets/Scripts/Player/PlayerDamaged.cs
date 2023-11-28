using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamaged : MonoBehaviour
{
    PlayerStat playerStat;
    PlayerStatUI playerStatUI;
    private int playerLife;
    private bool isInvulnerable;
    private Renderer playerRenderer;
    private GameObject player;

    private void Start() {
        player = GameObject.Find("Player");
        playerStat = GameObject.FindAnyObjectByType<PlayerStat>();
        playerStatUI = FindObjectOfType<PlayerStatUI>();
        playerLife = playerStat.getPlayerLife();
        if (playerLife < 1)
            playerLife = 3;
        isInvulnerable = false;
        playerRenderer = player.GetComponent<Renderer>();
    }

    private void Update()
    {
        // Debug.Log($"Player Life : {playerLife}");   // Test output
        if (isInvulnerable)
            playerRenderer.enabled = !playerRenderer.enabled;   // Blinking Effect 

        playerStatUI.UpdateHealthUI(playerLife);
    }

    private void OnTriggerEnter(Collider other) {
        // // Test: Collision with DamageRange and NPC obj
        // Debug.Log($"Damage Trigger Occured : {other.gameObject.tag}");

        if (other.gameObject.CompareTag("NPC")) {
            // 1. reduce hp
            playerLife--;
            Debug.Log($"Player Life : {playerLife}");   // Test output
            // 2. Sound Occured
            player.GetComponent<PlayerMoving>().SoundOccur();
            // 3. toggle Invulnerablity
            isInvulnerable = true;
            Invoke("toggleInvulnerable", 3.0f);     // Invulnerate for 3.0 seconds
        } else if (other.gameObject.CompareTag("Security")) {
            // Game over
            playerLife = 0;
        }

        if (playerLife <= 0) {
            // 1. Game Stop
            Debug.Log("GameOver");
            SceneManager.LoadScene("GameOver");
        }
    }

    private void toggleInvulnerable() {
        isInvulnerable = false;
        playerRenderer.enabled = true;
    }
}