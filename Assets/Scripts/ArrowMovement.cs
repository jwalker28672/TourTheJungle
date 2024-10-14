using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class ArrowMovement : MonoBehaviour
{
    public float arrowSpeed;

    private float startPosX;
    private Rigidbody2D rb;
    private GameObject gameManager;

    private PlayerScore score;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosX = transform.position.x;
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        score = gameManager.GetComponent<PlayerScore>();
    }

    void Update()
    {
        moveArrow();
        destroyArrow();
    }


    public void moveArrow()
    {
        rb.velocity = new Vector2(-arrowSpeed, rb.velocity.y);

    }

    private void destroyArrow()
    {
        if (transform.position.x <= startPosX - 80)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Score:" + score.getScore());
            score.setHighscore(score.getScore());

            SceneManager.LoadScene("Highscore");
        }
    }

}
