using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuiButtonHandler : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = GetComponent<GameManager>();
    }

    public void restartGame()
    {
        SceneManager.LoadScene("Level01");
        gameManager.resumeGame();
    }

    public void resumeGame()
    {
        gameManager.resumeGame();
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void displayMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
