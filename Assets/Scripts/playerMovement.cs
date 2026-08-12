using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    public float jumpSpeed = 5f;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public string colorNames;
    public GameObject gameOverUI;
    public AudioSource audioSource;
    public AudioClip jumpSound;
    public AudioClip gameOverSound;

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame || Mouse.current.leftButton.wasPressedThisFrame)
        {
            rb.linearVelocityY = jumpSpeed;
            audioSource.PlayOneShot(jumpSound);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == colorNames || collision.CompareTag("Color Switcher") || collision.CompareTag("Star") && collision.gameObject.name != "Win")
        {
            return;
        }
        else
        {
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
            rb.linearVelocityY = 0f;
            audioSource.PlayOneShot(gameOverSound);
        }
    }
}
