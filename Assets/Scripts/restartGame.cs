using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class restartGame : MonoBehaviour
{
    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame || Keyboard.current.enterKey.wasPressedThisFrame || Mouse.current.leftButton.wasPressedThisFrame)
        {
            RestartGame();
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Scene");
    }
}
