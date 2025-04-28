using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject restartButton;
    public ScoreManager scoreManager;

    private bool isGameOver = false;

    void Start()
    {
        restartButton.SetActive(false);
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        if (isGameOver) return;

        isGameOver = true;
        Time.timeScale = 0f;  // ゲームオーバー時に時間を止める
        restartButton.SetActive(true);  // リスタートボタンを表示

        // スコア停止
        if (scoreManager != null)
        {
            scoreManager.StopScore();
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}





