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
        Time.timeScale = 0f;  // �Q�[���I�[�o�[���Ɏ��Ԃ��~�߂�
        restartButton.SetActive(true);  // ���X�^�[�g�{�^����\��

        // �X�R�A��~
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





