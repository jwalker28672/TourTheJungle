using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighscoreMenuManager : MonoBehaviour
{
    public GameObject highscoreMenu;

    private PlayerScore score;

    public TMP_Text highscore1;
    public TMP_Text highscore2;
    public TMP_Text highscore3;
    public TMP_Text highscore4;
    public TMP_Text highscore5;

    void Start()
    {
        Debug.Log("Highscore 1. " + PlayerPrefs.GetInt("Highscore1"));
        Debug.Log("Highscore 2. " + PlayerPrefs.GetInt("Highscore2"));
        Debug.Log("Highscore 3. " + PlayerPrefs.GetInt("Highscore3"));
        Debug.Log("Highscore 4. " + PlayerPrefs.GetInt("Highscore4"));
        Debug.Log("Highscore 5. " + PlayerPrefs.GetInt("Highscore5"));


        highscore1.text = "1. " + PlayerPrefs.GetInt("Highscore1");
        highscore2.text = "2. " + PlayerPrefs.GetInt("Highscore2");
        highscore3.text = "3. " + PlayerPrefs.GetInt("Highscore3");
        highscore4.text = "4. " + PlayerPrefs.GetInt("Highscore4");
        highscore5.text = "5. " + PlayerPrefs.GetInt("Highscore5");
    }


    public void loadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void playAgain()
    {
        SceneManager.LoadScene("Level01");
        Time.timeScale = 1.0f;
    }

}
