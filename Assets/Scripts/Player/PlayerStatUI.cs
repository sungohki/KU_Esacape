using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStatUI : MonoBehaviour
{
    public Image[] hearts; // 하트 이미지 배열
    //public TMP_Text lifeText;
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
        //UpdatePlayerLifeUI();

        hearts = GetComponentsInChildren<Image>();

        // PlayerStat의 Life 수치에 따라 초기 하트 표시
        UpdateHearts();

    }

    private void Update()
    {
        // Text UI에 플레이어 체력 표시
        //lifeText.text = "Life: " + playerStat.playerLife;
        //UpdateHearts();
    }

    public void UpdatePlayerLifeUI()
    {
        // PlayerStat 스크립트로부터 PlayerLife 값을 가져와 UI Text에 표시
        //lifeText.text = "Player Life: " + playerStat.getPlayerLife().ToString();
    }

    private void UpdateHearts()
    {
        if (playerStat != null)
        {
            int currentHealth = playerStat.getPlayerLife();

            // Life 수치에 따라 하트 표시 업데이트
            for (int i = 0; i < hearts.Length; i++)
            {
                if (i < currentHealth)
                {
                    // 현재 Life 수치보다 작은 인덱스의 하트를 활성화
                    hearts[i].enabled = true;
                }
                else
                {
                    // 현재 Life 수치보다 크거나 같은 인덱스의 하트를 비활성화
                    hearts[i].enabled = false;
                }
            }
        }
    }
}
