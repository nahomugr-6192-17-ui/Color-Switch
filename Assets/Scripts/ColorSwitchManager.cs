using UnityEngine;

public class ColorSwitchManager : MonoBehaviour
{
    public Color[] colors;
    public playerMovement player;
    public SpriteRenderer sr;
    public string[] colorNames;
    public AudioSource audioSource;
    public AudioClip colorSwitchSound;

    public Color HexToColor(string hex)
    {
        Color color;
        if (ColorUtility.TryParseHtmlString(hex, out color))
        {
            return color;
        }

        return Color.white;
    }

    void Start()
    {
        RandomColor();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            int randomIndex = Random.Range(0, colors.Length);
            player.sr.color = colors[randomIndex];
            player.colorNames = colorNames[randomIndex];
            audioSource.PlayOneShot(colorSwitchSound);
            Destroy(gameObject);
        }
    }

    public void RandomColor()
    {
        colors = new Color[4]
        {
            HexToColor("#34E2F2"), // Cyan
            HexToColor("#F5DF0E"), // Yellow
            HexToColor("#8C13FA"), // Purple
            HexToColor("#FE0080"), // Red
        };
        colorNames = new string[4]
        {
            "Cyan",
            "Yellow",
            "Purple",
            "Red"
        };
        int randomIndex = Random.Range(0, colors.Length);
        player.sr.color = colors[randomIndex];
        player.colorNames = colorNames[randomIndex];
    }
}
