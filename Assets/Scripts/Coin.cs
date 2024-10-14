using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private GameObject gameManager;
    private PlayerScore playerScore;
    public int val;

    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        playerScore = gameManager.GetComponent<PlayerScore>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerScore.setPlayerScore(val);
            Destroy(this.gameObject);
        }
    }
}
