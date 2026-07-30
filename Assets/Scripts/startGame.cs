using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class startGame : MonoBehaviour
{
    public void StartGame()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame || Keyboard.current.enterKey.wasPressedThisFrame || Mouse.current.leftButton.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Main Scene");
        }
    }
}
