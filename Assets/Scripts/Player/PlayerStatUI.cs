using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStatUI : MonoBehaviour
{
    public TMP_Text lifeText;
    public PlayerStat playerStat; // PlayerStat 스크립트 참조

    void Start()
    {
        GameObject playerObject = GameObject.Find("Player");
        if (playerObject != null)
        {
            playerStat = playerObject.GetComponent<PlayerStat>();
        }
        else
        {
            Debug.LogError("Player object not found!");
        }

        // UI에 초기 PlayerLife 값을 표시
        UpdatePlayerLifeUI();
    }

    private void Update()
    {
        // Text UI에 플레이어 체력 표시
        lifeText.text = "Life: " + playerStat.playerLife;
    }

    public void UpdatePlayerLifeUI()
    {
        // PlayerStat 스크립트로부터 PlayerLife 값을 가져와 UI Text에 표시
        lifeText.text = "Player Life: " + playerStat.getPlayerLife().ToString();
    }

}
