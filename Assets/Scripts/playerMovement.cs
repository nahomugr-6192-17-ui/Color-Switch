using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    public float jumpSpeed = 5f;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public string colorNames;
    public ColorSwitchManager color;

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
        if (collision.gameObject.name == "ColorSwitcher")
        {
            return;
        }
        else if (collision.gameObject.name != colorNames && collision.gameObject.name != "Star")
        {
            Debug.Log("Game Over");
        }
    }
}
