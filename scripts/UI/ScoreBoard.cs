using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreBoard : MonoBehaviour
{
    public int score;
    TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = "- 0";
    }

    // Update is called once per frame
    public void AdBombScore(int bombs)
    {
        if(score < 3)
        {
            score += bombs;
            scoreText.text = "- " + score.ToString() + "/3";
        }
       
    }

    public void DellBombScore(int bombs)
    {
        score -= bombs;
        scoreText.text = "- " + score.ToString() + "/3";
    }
}
