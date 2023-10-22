using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // 게임 오버 시 호출할 함수
    public void GameOver()
    {
        Debug.Log("GameOver");
        // 게임 일시 중지
        Time.timeScale = 0;
    }

    // 게임 클리어 시 호출할 함수
    public void GameClear()
    {
        // "GameClearScene" 씬으로 전환
        SceneManager.LoadScene("GameClearScene");
    }
}