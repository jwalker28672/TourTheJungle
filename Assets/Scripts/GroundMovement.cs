using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{

    public float movementSpeed;
    private float startPosx;

    void Start()
    {
        startPosx = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        moveGround();
        destroyGround();
    }

    private void moveGround()
    {
        transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
    }

    private void destroyGround()
    {
        if (transform.position.x <= startPosx - 80)
        {
            Destroy(this.gameObject);
        }
    }

}
