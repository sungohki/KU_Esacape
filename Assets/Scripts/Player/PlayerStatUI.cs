using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStatUI : MonoBehaviour
{
    public Image[] hearts; // ��Ʈ �̹��� �迭
    //public TMP_Text lifeText;
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
        //UpdatePlayerLifeUI();

        hearts = GetComponentsInChildren<Image>();

        // PlayerStat�� Life ��ġ�� ���� �ʱ� ��Ʈ ǥ��
        UpdateHearts();

    }

    private void Update()
    {
        // Text UI�� �÷��̾� ü�� ǥ��
        //lifeText.text = "Life: " + playerStat.playerLife;
        //UpdateHearts();
    }

    public void UpdatePlayerLifeUI()
    {
        // PlayerStat ��ũ��Ʈ�κ��� PlayerLife ���� ������ UI Text�� ǥ��
        //lifeText.text = "Player Life: " + playerStat.getPlayerLife().ToString();
    }

    private void UpdateHearts()
    {
        if (playerStat != null)
        {
            int currentHealth = playerStat.getPlayerLife();

            // Life ��ġ�� ���� ��Ʈ ǥ�� ������Ʈ
            for (int i = 0; i < hearts.Length; i++)
            {
                if (i < currentHealth)
                {
                    // ���� Life ��ġ���� ���� �ε����� ��Ʈ�� Ȱ��ȭ
                    hearts[i].enabled = true;
                }
                else
                {
                    // ���� Life ��ġ���� ũ�ų� ���� �ε����� ��Ʈ�� ��Ȱ��ȭ
                    hearts[i].enabled = false;
                }
            }
        }
    }
}
