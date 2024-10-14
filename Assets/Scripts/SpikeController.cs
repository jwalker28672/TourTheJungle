using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController : MonoBehaviour
{
    private float startPosy;
    public float speed;
    public float offset;

    private bool extend;

    void Start()
    {
        extend = true;
        startPosy = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        moveSpikes();
    }


    private void moveSpikes()
    {
        if (extend)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        if (transform.position.y >= startPosy + offset)
        {
            extend = false;
        }
        else if (transform.position.y <= startPosy)
        {
            extend = true;
        }


    }


}
