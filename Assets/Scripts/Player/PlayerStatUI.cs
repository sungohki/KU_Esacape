using UnityEngine;
using UnityEngine.UI;

public class PlayerStatUI : MonoBehaviour
{
    public Text lifeText;
    public PlayerStat playerStat; // PlayerStat ��ũ��Ʈ ����

    private void Update()
    {
        // Text UI�� �÷��̾� ü�� ǥ��
        lifeText.text = "Life: " + playerStat.playerLife;
    }
}
