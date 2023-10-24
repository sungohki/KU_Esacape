using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public void GameOver()
    //{
    //    Debug.Log("GameOver");
    //    Time.timeScale = 0;
    //}

    //public void GameClear()
    //{
    //    SceneManager.LoadScene("GameClearScene");
    //}

    public void OnClickRestart()
    {
        SceneManager.LoadScene("Floor3");
    }

}