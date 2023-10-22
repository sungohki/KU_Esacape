using UnityEngine;

public class PlayerDamaged : MonoBehaviour
{
    PlayerStat playerStat = new PlayerStat();

    private int playerLife;
    private bool isInvulnerable;
    private Renderer playerRenderer;
    private void Start() {
        playerLife = playerStat.getPlayerLife();
        if (playerLife < 1)
            playerLife = 3;
        isInvulnerable = false;
        playerRenderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (isInvulnerable)
            playerRenderer.enabled = !playerRenderer.enabled;
    }

    private void OnCollisionEnter(Collision other) {
        // Collision with DamageRange and NPC obj
        if (other.gameObject.CompareTag("NPC") && playerLife >= 0) {
            // 1. reduce hp
            playerLife--;
            Debug.Log($"Player Life : {playerLife}");   // Test output

            // 2. toggle Invulnerablity
            isInvulnerable = true;
            Invoke("toggleInvulnerable", 3.0f);     // Invulnerate for 3.0 seconde
        }
    }

    private void toggleInvulnerable() {
        isInvulnerable = false;
        playerRenderer.enabled = true;
    }
}