using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float xSpeed; //variable for horizontal speed
    public float ySpeed; //variable for vertical speed

    public bool xMove = true;  //variable for horizontal state
    public bool yMove = true;  //variable for vertical state

    float xBorder = 7.5f;  //variable for horizontal border
    float yBorder = 5f;    //variable for vertical border

    int playerOneScore;
    public Text scoreTextP1;

    int playerTwoScore;
    public Text scoreTextP2;


    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.05f; //declares value of horizontal speed
        ySpeed = 0.05f; //declares value of vertical speed

    }

    // Update is called once per frame
    void Update()
    {

        if (xMove == true)
        {
            transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y);
        }

        else
        {
            transform.position = new Vector2(transform.position.x - xSpeed, transform.position.y);
        }

        if (transform.position.x >= xBorder) //if the ball hits the right edge 
        {
            //xMove = false; //bounce left
            transform.position = Vector2.zero; //resets to the center
            playerOneScore++;

            //playerOneScore += 1;
        }
        if (transform.position.x <= -xBorder) //if the ball hits the left edge
        {
            //xMove = true;  //bounce right
            transform.position = Vector2.zero;  //resets to the center
            playerTwoScore++;

            //playerTwoScore += 1;
        }

        if (yMove == true)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed);
        }

        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - ySpeed);
        }

        if (transform.position.y >= yBorder)
        {
            yMove = false;
        }
        if (transform.position.y <= -yBorder)
        {
            yMove = true;
        }

        scoreTextP1.text = playerOneScore.ToString();


        scoreTextP2.text = playerTwoScore.ToString();
    }

    void OnCollisionEnter2D(Collision2D collision){ // when collision happens

        if (collision.collider.CompareTag("Player")){ //if the other object is a player
            Debug.Log("hit"); //console tells me it hit

            // bounces in the other direction
            if (xMove == true){
                xMove = false; 
            }
            else if (xMove == false){
                xMove = true;
            }
        }
    }
}
