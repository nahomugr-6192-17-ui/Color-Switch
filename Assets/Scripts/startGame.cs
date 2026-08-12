using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class startGame : MonoBehaviour
{
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame || Keyboard.current.enterKey.wasPressedThisFrame || Mouse.current.leftButton.wasPressedThisFrame)
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Scene");
    }
}
