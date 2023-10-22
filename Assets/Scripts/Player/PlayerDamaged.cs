using UnityEngine;

public class PlayerDamaged : MonoBehaviour
{
    PlayerStat playerStat = new PlayerStat();

    private int playerLife;
    private bool isInvulnerable;
    private Renderer playerRenderer;
    private GameObject player;
    private void Start() {
        player = GameObject.Find("Player");
        playerLife = playerStat.getPlayerLife();
        if (playerLife < 1)
            playerLife = 3;
        isInvulnerable = false;
        playerRenderer = player.GetComponent<Renderer>();
    }

    private void Update()
    {
        if (isInvulnerable)
            // Blinking Effect 
            playerRenderer.enabled = !playerRenderer.enabled;
    }

    private void OnCollisionEnter(Collision other) {
        // Collision with DamageRange and NPC obj
        if (other.gameObject.CompareTag("NPC")) {
            // 1. reduce hp
            playerLife--;
            Debug.Log($"Player Life : {playerLife}");   // Test output

            // 2. toggle Invulnerablity
            isInvulnerable = true;
            Invoke("toggleInvulnerable", 3.0f);     // Invulnerate for 3.0 seconds
        }
    }

    private void toggleInvulnerable() {
        isInvulnerable = false;
        playerRenderer.enabled = true;
    }
}