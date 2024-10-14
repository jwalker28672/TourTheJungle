using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRigidBody;
    
    public GameObject playerGameObject;

    public GameManager gameManager;

    private PlayerScore score;

    public  float movementSpeed;
    public  float jumpHeight;
    public  float jumpLength;
    private float jumpTime;
    private float inputHorizontal;
    private float playerHeight;

    private bool isjumping;
    private bool isgrounded;

    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
        playerHeight = playerGameObject.transform.localScale.y;
        score = gameManager.GetComponent<PlayerScore>();
    }

    void Update()
    {
        lateralPlayerMovement();
        playerJump();
        playerCrouch();

    }

    private void lateralPlayerMovement()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");

        playerRigidBody.velocity = new Vector2(movementSpeed * inputHorizontal, playerRigidBody.velocity.y);

        if (inputHorizontal != 0)
        {
            flipPlayerSprite(inputHorizontal);
        }
    }

    private void flipPlayerSprite(float inputHorizontal)
    {
        if (inputHorizontal > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if (inputHorizontal < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

    }


    private void playerCrouch()
    {
        if (isgrounded && Input.GetKey(KeyCode.C))
        {
            playerGameObject.transform.localScale =  new Vector2(playerGameObject.transform.localScale.x,0.75f);

        }

        if (isjumping && Input.GetKey(KeyCode.C))
        {
            playerGameObject.transform.localScale = new Vector2(playerGameObject.transform.localScale.x, playerHeight);
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            playerGameObject.transform.localScale = new Vector2(playerGameObject.transform.localScale.x, playerHeight);
        }
    }

    private void playerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isgrounded)
        {
            isgrounded = false;
            isjumping = true;
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, jumpHeight);

        }

        if (Input.GetKey(KeyCode.Space) && isjumping)
        {

            if (jumpTime < jumpLength)
            {
                playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, jumpHeight);
                jumpTime += Time.deltaTime;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isjumping = false;
            jumpTime = 0f;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isgrounded = true;
            jumpTime = 0f;
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Score:" + score.getScore());
            score.setHighscore(score.getScore());

            SceneManager.LoadScene("Highscore");
        }

    }
}
