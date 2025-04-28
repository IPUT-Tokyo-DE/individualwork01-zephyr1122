using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private float score = 0f;
    private bool isCounting = true;

    void Update()
    {
        if (isCounting)
        {
            score += Time.deltaTime * 100f;
            scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
        }
    }

    public void StopScore()
    {
        isCounting = false;
    }

    public void ResetScore()
    {
        score = 0f;
        scoreText.text = "Score: 0";
        isCounting = true;
    }
}
