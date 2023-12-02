using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStat : MonoBehaviour
{
    // // Stats
    // Stat for Life
    public int playerLife = 3;
    public Image keyImage;

    // Stat for Movement
    [SerializeField] public float playerMoveSpeed;
    [SerializeField] public float playerAddSpeed;

    // Stat for State
    [SerializeField] private int hasKey;
    // {false:default, true:attackAvailable}
    // PlayerData playerData = Resources.Load<PlayerData>("PlayerData");

    private void Start() {
        
        playerMoveSpeed = 10;
        playerAddSpeed = 1.5f;
        hasKey = PlayerPrefs.GetInt("hasKey", 0);

        if (keyImage != null)
        {
            keyImage.gameObject.SetActive(false);
        }
    }

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

    public int getHasKey() {
        return (hasKey);
    }
    public void setHasKey(int data) {
        hasKey = data;

        if (hasKey == 1 && keyImage != null)
        {
            keyImage.gameObject.SetActive(true);
        }
    }


    public void soundOccur() {
        
    }
}
