using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;
    public TextMeshProUGUI scoreText;

    private bool isEnding = false;

    void Awake()
    {
        instance = this;
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;

        // ⭐ 코인 5개 → 바로 다음 씬
        if (score >= 1 && !isEnding)
        {
            isEnding = true;

            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(2); // 👉 다음 씬 번호
    }
}