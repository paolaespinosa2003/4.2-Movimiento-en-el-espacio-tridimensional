
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;

    public void SetScoreText(string s)
    {
        if (scoreText != null) scoreText.text = s;
    }
    public void SetHighScoreText(string s)
    {
        if (highScoreText != null) highScoreText.text = s;
    }
}
