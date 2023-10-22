using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    // Stat for Life
    [SerializeField] private int playerLife = 3;

    // Stat for Movement
    [SerializeField] private float playerMoveSpeed = 10;
    [SerializeField] private float playerAddSpeed = 1.5f;

    // Stat for State
    [SerializeField] private bool playerAttack = false;
    // {false:default, true:attackAvailable}

    // // Stat for Ranges
    // [SerializeField] private float playerAttackRange;
    // [SerializeField] private float playerDamageRange;
    // [SerializeField] private float playerSoundRange;

    // // Getter & Setter Funcs.
    public int getPlayerLife() {
        return (playerLife);
    }
    public void setPlayerLife(int data) {
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

    public bool getPlayerAttack() {
        return (playerAttack);
    }
    public void setPlayerAttack(bool data) {
        playerAttack = data;
    }

    // public float getPlayerAttackRange() {
    //     return (playerAttackRange);
    // }
    // public void setPlayerAttackRange(float data) {
    //     playerAttackRange = data;
    // }

    // public float getPlayerDamageRange() {
    //     return (playerDamageRange);
    // }
    // public void setPlayerDamageRange(float data) {
    //     playerDamageRange = data;
    // }

    // public float getPlayerSoundRange() {
    //     return (playerDamageRange);
    // }
    // public void setPlayerSoundRange(float data) {
    //     playerDamageRange = data;
    // }
}
