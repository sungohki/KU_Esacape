using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    // // Stats
    // Stat for Life
    [SerializeField] private int playerLife = 3;

    // Stat for Movement
    [SerializeField] private float playerMoveSpeed = 10;
    [SerializeField] private float playerAddSpeed = 1.5f;

    // Stat for State
    [SerializeField] private bool hasKey = false;
    // {false:default, true:attackAvailable}

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

    public bool getHasKey() {
        return (hasKey);
    }
    public void setHasKey(bool data) {
        hasKey = data;
    }


    public void soundOccur() {
        
    }
}
