using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    public float jumpSpeed = 5f;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public string colorNames;

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame || Mouse.current.leftButton.wasPressedThisFrame)
        {
            rb.linearVelocityY = jumpSpeed;
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
            Debug.Log("Game Over");
        }
    }
}
