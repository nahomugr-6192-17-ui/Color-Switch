using UnityEngine;

public class winScript : MonoBehaviour
{
    public playerMovement player;
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            player.rb.gravityScale = 0;
        }
    }
}
