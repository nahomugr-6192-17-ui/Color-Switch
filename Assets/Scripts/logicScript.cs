using UnityEngine;
using UnityEngine.UI;

public class logicScript : MonoBehaviour
{

    public Text scoreText;
    

    public void addScore()
    {
        int score = int.Parse(scoreText.text);
        score++;
        scoreText.text = score.ToString();
    }
}
