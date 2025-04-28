using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject restartButton;
    public ScoreManager scoreManager; // スコアマネージャーの参照

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
        Time.timeScale = 0f; // ゲームを停止
        restartButton.SetActive(true); // リスタートボタンを表示

        // スコア停止
        if (scoreManager != null)
        {
            scoreManager.StopScore();
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f; // ゲーム再開
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // 現在のシーンを再読み込み
    }
}


