using UnityEngine;

public class PlayerDamaged : MonoBehaviour
{
    PlayerStat playerStat;
    private int playerLife;
    private bool isInvulnerable;
    private Renderer playerRenderer;
    private GameObject player;
    private void Start() {
        player = GameObject.Find("Player");
        // Debug.Log($"player is {player}");
        playerStat = GameObject.FindAnyObjectByType<PlayerStat>();
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
    }

    private void OnTriggerEnter(Collider other) {
        // Collision with DamageRange and NPC obj
        // Debug.Log($"Damage Trigger Occured : {other.gameObject.tag}");
        if (other.gameObject.CompareTag("NPC")) {
            // 1. reduce hp
            playerLife--;
            Debug.Log($"Player Life : {playerLife}");   // Test output

            // 2. toggle Invulnerablity
            isInvulnerable = true;
            Invoke("toggleInvulnerable", 3.0f);     // Invulnerate for 3.0 seconds

            
        } else if (other.gameObject.CompareTag("Security")) {
            // Game over
            playerLife = 0;
        }

        if (playerLife <= 0) {
            // 1. Game Stop
            Debug.Log("GameOver");
            // Time.timeScale = 0;
        }
    }

    private void toggleInvulnerable() {
        isInvulnerable = false;
        playerRenderer.enabled = true;
    }
}