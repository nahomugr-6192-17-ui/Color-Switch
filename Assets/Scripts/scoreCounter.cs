using UnityEngine;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour
{
    public static scoreCounter Instance;

    public Text scoreText;

    private int score;

    void Start()
    {
        Instance = this;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}