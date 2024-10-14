using System.Collections;
using System.Collections.Generic;
using TMPro;
//using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    private int score;
    public TMP_Text guiScore;


    void Start()
    {
        score = 0;
        setGUIScore();
    }


    public int getScore()
    {
        return score;
    }

    public void setPlayerScore(int val)
    {
        score += val;
        setGUIScore();
    }

    public void setGUIScore()
    {
        guiScore.text = "Score: " + score.ToString();

    }

    public void setHighscore(int val)
    {
        if (score >= PlayerPrefs.GetInt("Highscore1"))
        {
            PlayerPrefs.SetInt("Highscore1", score);
        }
        else if (score >= PlayerPrefs.GetInt("Highscore2"))
        {
            PlayerPrefs.SetInt("Highscore2", score);
        }
        else if (score >= PlayerPrefs.GetInt("Highscore3"))
        {
            PlayerPrefs.SetInt("Highscore4", score);
        }
        else if (score >= PlayerPrefs.GetInt("Highscore4"))
        {
            PlayerPrefs.SetInt("Highscore4", score);
        }
        else if (score >= PlayerPrefs.GetInt("Highscore5"))
        {
            PlayerPrefs.SetInt("Highscore5", score);
        }

    }

}
