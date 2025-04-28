using UnityEngine;
using UnityEngine.UI;  // スコアをUIに表示するために必要

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;  // スコア表示用のText UIコンポーネント

    private bool isScoreActive = true;  // スコアが加算されているかを管理するフラグ

    void Start()
    {
        // スコアの初期化と表示を更新
        UpdateScoreText();
    }

    void Update()
    {
        // もしスコアが有効であれば、時間経過でスコアを増やす処理を追加することも可能
        if (isScoreActive)
        {
            // 例: 時間経過でスコアを増やす
            IncreaseScore(1);
            UpdateScoreText();  // スコア表示を更新
        }
    }

    public void IncreaseScore(int amount)
    {
        if (isScoreActive)  // スコアが有効なときだけ加算
        {
            score += amount;
        }
    }

    public void StopScore()
    {
        isScoreActive = false;  // スコア加算を停止
    }

    public void RestartScore()
    {
        score = 0;  // スコアをリセット
        isScoreActive = true;  // スコア加算を再開
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}

