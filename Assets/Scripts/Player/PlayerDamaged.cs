using UnityEngine;

public class PlayerDamaged : MonoBehaviour
{
    PlayerStat playerStat;
    public GameManager manager;
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
            // Blinking Effect 
            playerRenderer.enabled = !playerRenderer.enabled;
    }

    private void OnTriggerEnter(Collider other) {
        // Collision with DamageRange and NPC obj
        Debug.Log($"Damage Trigger Occured : {other.gameObject.tag}");
        if (other.gameObject.CompareTag("NPC")) {
            // 1. reduce hp
            playerLife--;
            Debug.Log($"Player Life : {playerLife}");   // Test output

            // 2. toggle Invulnerablity
            isInvulnerable = true;
            Invoke("toggleInvulnerable", 3.0f);     // Invulnerate for 3.0 seconds

            if (playerLife <= 0)
            {
                Debug.Log("GameOver");
                // Game Stop
                Time.timeScale = 0;

                // Use GameManger Script
                // manager.GameOver();
            }
        }
    }

    private void toggleInvulnerable() {
        isInvulnerable = false;
        playerRenderer.enabled = true;
    }
}