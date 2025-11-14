
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    private int score = 0;
    private float accumulator = 0f;
    public float pointsPerSecond = 10f;

    void Start()
    {
        int hs = PlayerPrefs.GetInt("HighScore", 0);
        if (highScoreText != null) highScoreText.text = "Record: " + hs;
        UpdateScoreText();
    }

    void Update()
    {
        // incrementa score por tiempo (puedes adaptar a interacciones)
        accumulator += Time.deltaTime * pointsPerSecond;
        int newScore = Mathf.FloorToInt(accumulator);
        if (newScore != score)
        {
            score = newScore;
            UpdateScoreText();

            // guardar highscore si aplica
            int hs = PlayerPrefs.GetInt("HighScore", 0);
            if (score > hs)
            {
                PlayerPrefs.SetInt("HighScore", score);
                if (highScoreText != null) highScoreText.text = "Record: " + score;
            }
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null) scoreText.text = "Score: " + score;
    }
}
