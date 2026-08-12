using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

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

    public void StartGame()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame || Keyboard.current.enterKey.wasPressedThisFrame || Mouse.current.leftButton.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Main Scene");
        }
    }
}