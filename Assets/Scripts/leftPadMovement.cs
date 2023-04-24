using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftPadMovement : MonoBehaviour
{

    public float speed = 10f;

    public float yBorder = 4.5f;

    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var velocity = rb2d.velocity;


        if (Input.GetKey(KeyCode.W) && transform.position.y < yBorder)
        {
            velocity.y = speed;

            Debug.Log("W");
        }

        else
        {
            velocity.y = 0;

        }

        if (Input.GetKey(KeyCode.S) && transform.position.y > -yBorder)
        {
            velocity.y = -speed;
        }




        rb2d.velocity = velocity;
    }
}
