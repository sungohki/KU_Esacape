using UnityEngine;

public class PlayerStatUI : MonoBehaviour
{
    // 가상의 UI 엘리먼트로 가정
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public void UpdateHealthUI(int health)
    {
        // health에 따라 하트 UI를 활성화/비활성화
        switch (health)
        {
            case 3:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(true);
                break;
            case 2:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(false);
                break;
            case 1:
                heart1.SetActive(true);
                heart2.SetActive(false);
                heart3.SetActive(false);
                break;
            default:
                heart1.SetActive(false);
                heart2.SetActive(false);
                heart3.SetActive(false);
                break;
        }
    }
}