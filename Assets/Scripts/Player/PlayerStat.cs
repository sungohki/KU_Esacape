using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    // Stat for Life
    [SerializeField] private int playerLife;

    // Stat for Movement
    [SerializeField] private float playerMoveSpeed;
    [SerializeField] private float playerAddSpeed;

    // Stat for State
    [SerializeField] private int playerState;

    // Stat for Ranges
    [SerializeField] private float playerAttackRange;
    [SerializeField] private float playerDamageRange;

    // // Getter & Setter Funcs.
    public int getPlayerLife() {
        return (playerLife);
    }
    public void set(int data) {
        playerLife = data;
    }

    public float getPlayerMoveSpeed() {
        return (playerMoveSpeed);
    }
    public void setPlayerMoveSpeed(float data) {
        playerMoveSpeed = data;
    }

    public float getPlayerAddSpeed() {
        return (playerAddSpeed);
    }
    public void setPlayerAddSpeed(float data) {
        playerAddSpeed = data;
    }

    public int getPlayerState() {
        return (playerState);
    }
    public void setPlayerState(int data) {
        playerState = data;
    }

    public float getPlayerAttackRange() {
        return (playerAttackRange);
    }
    public void setPlayerAttackRange(int data) {
        playerAttackRange = data;
    }

    public float getPlayerDamageRange() {
        return (playerDamageRange);
    }
    public void setPlayerDamageRange(int data) {
        playerDamageRange = data;
    }
}
