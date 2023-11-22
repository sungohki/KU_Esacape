using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStatUI : MonoBehaviour
{
    public TMP_Text lifeText;
    public PlayerStat playerStat; // PlayerStat ��ũ��Ʈ ����

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

        // UI�� �ʱ� PlayerLife ���� ǥ��
        UpdatePlayerLifeUI();
    }

    private void Update()
    {
        // Text UI�� �÷��̾� ü�� ǥ��
        lifeText.text = "Life: " + playerStat.playerLife;
    }

    public void UpdatePlayerLifeUI()
    {
        // PlayerStat ��ũ��Ʈ�κ��� PlayerLife ���� ������ UI Text�� ǥ��
        lifeText.text = "Player Life: " + playerStat.getPlayerLife().ToString();
    }

}
