using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGuiButtonHandler : MonoBehaviour
{

    private menuManager menuManager;

    void Start()
    {
        menuManager = GetComponent<menuManager>();
    }

    public void playGame()
    {
        SceneManager.LoadScene("Level01");
        Time.timeScale = 1.0f;
    }

    public void highScore()
    {
        SceneManager.LoadScene("Highscore");
    }


    public void exitGame()
    {
        Application.Quit();
    }

}
