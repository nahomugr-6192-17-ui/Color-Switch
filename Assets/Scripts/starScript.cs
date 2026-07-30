using UnityEngine;

public class starScript : MonoBehaviour
{
    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Star collected!");
            Destroy(gameObject);
        }
    }
}
