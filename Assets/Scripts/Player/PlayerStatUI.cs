using UnityEngine;

public class PlayerStatUI : MonoBehaviour
{
    // ������ UI ������Ʈ�� ����
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public void UpdateHealthUI(int health)
    {
        // health�� ���� ��Ʈ UI�� Ȱ��ȭ/��Ȱ��ȭ
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