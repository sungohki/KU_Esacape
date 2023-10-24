using UnityEngine;
using UnityEngine.UI;

public class PlayerStatUI : MonoBehaviour
{
    public Text lifeText;
    public PlayerStat playerStat; // PlayerStat 스크립트 참조

    private void Update()
    {
        // Text UI에 플레이어 체력 표시
        lifeText.text = "Life: " + playerStat.playerLife;
    }
}
