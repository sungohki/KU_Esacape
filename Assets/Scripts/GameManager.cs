using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // ���� ���� �� ȣ���� �Լ�
    public void GameOver()
    {
        Debug.Log("GameOver");
        // ���� �Ͻ� ����
        Time.timeScale = 0;
    }

    // ���� Ŭ���� �� ȣ���� �Լ�
    public void GameClear()
    {
        // "GameClearScene" ������ ��ȯ
        SceneManager.LoadScene("GameClearScene");
    }
}