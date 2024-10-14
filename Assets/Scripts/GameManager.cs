using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu;
    private PlayerScore score;
    private int[] highscores;

    private void Start()
    {
        score = gameObject.GetComponent<PlayerScore>();
        highscores = new int[4];
    }

    private void Update()
    {
        pauseButtonPress();
    }

    public void pauseButtonPress()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            showPauseMenu();
            pauseGame();
        }
    }

    public void pauseGame()
    {
        Time.timeScale = 0f;
    }

    public void resumeGame()
    {
        Time.timeScale = 1.0f;
        hidePauseMenu();
    }

    public void showPauseMenu()
    {
        pauseMenu.SetActive(true);
    }

    public void hidePauseMenu()
    {
        pauseMenu.SetActive(false);
    }

}
