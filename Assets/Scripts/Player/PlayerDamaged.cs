using UnityEngine;

public class PlayerDamaged : MonoBehaviour
{
    PlayerStat playerStat = new PlayerStat();

    private int playerLife;
    void Start() {
        playerLife = playerStat.getPlayerLife();
        if (playerLife < 1)
            playerLife = 3;
    }

    private void OnCollisionEnter(Collision other) {
        // Collision with DamageRange and NPC obj
        if (true && playerLife >= 0) {
            playerLife--;
            Debug.Log($"Player Life : {playerLife}");   // Test output
        }
    }
}