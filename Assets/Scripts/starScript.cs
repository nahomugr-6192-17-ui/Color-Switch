using UnityEngine;

public class starScript : MonoBehaviour
{

    public AudioSource starSound;
    public AudioClip starSoundClip;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            scoreCounter.Instance.AddScore();
            starSound.PlayOneShot(starSoundClip);
            Destroy(gameObject);
        }
    }
}
