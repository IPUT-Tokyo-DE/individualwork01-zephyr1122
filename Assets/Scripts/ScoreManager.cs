using UnityEngine;
using UnityEngine.UI;  // �X�R�A��UI�ɕ\�����邽�߂ɕK�v

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;  // �X�R�A�\���p��Text UI�R���|�[�l���g

    private bool isScoreActive = true;  // �X�R�A�����Z����Ă��邩���Ǘ�����t���O

    void Start()
    {
        // �X�R�A�̏������ƕ\�����X�V
        UpdateScoreText();
    }

    void Update()
    {
        // �����X�R�A���L���ł���΁A���Ԍo�߂ŃX�R�A�𑝂₷������ǉ����邱�Ƃ��\
        if (isScoreActive)
        {
            // ��: ���Ԍo�߂ŃX�R�A�𑝂₷
            IncreaseScore(1);
            UpdateScoreText();  // �X�R�A�\�����X�V
        }
    }

    public void IncreaseScore(int amount)
    {
        if (isScoreActive)  // �X�R�A���L���ȂƂ��������Z
        {
            score += amount;
        }
    }

    public void StopScore()
    {
        isScoreActive = false;  // �X�R�A���Z���~
    }

    public void RestartScore()
    {
        score = 0;  // �X�R�A�����Z�b�g
        isScoreActive = true;  // �X�R�A���Z���ĊJ
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}

