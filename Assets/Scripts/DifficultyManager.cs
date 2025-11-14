
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public PlayerMovement player;
    public ScoreManager scoreManager;
    public float speedIncreasePerMinute = 1f;

    private float elapsed = 0f;

    void Update()
    {
        elapsed += Time.deltaTime;
        // Incremento suave de velocidad basado en tiempo
        if (elapsed >= 1f)
        {
            float factor = (speedIncreasePerMinute / 60f) * elapsed;
            player.forwardSpeed += factor * Time.deltaTime;
            elapsed = 0f;
        }
    }
}
