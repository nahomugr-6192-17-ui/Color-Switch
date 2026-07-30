using UnityEngine;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour
{
    public Text scoreText;
    private int score;

    public void addScore()
    {
        score++;
        scoreText.text = score.ToString("0");
    }
}
