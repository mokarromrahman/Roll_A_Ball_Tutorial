using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //Called before rendering a frame
    //this is where most of the game code will go
    //private void Update()
    //{
    //don't need this 
    //}

    //Variables for score
    private int count;
    public Text countText;

    //win text
    public Text winText;

    //Speed of ball
    public float speed;

    //Rigidbody of the player
    private Rigidbody rb;

    private void Start()
    {
        //initialize the ball rigidbody
        rb = GetComponent<Rigidbody>();

        //Initialize with a count of 0
        count = 0;
        SetCountText(countText, count);

        //Initialize the wintext to blank
        SetWinText(winText, "");
    }

    //Called before any physics calculations are done
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //We want to move the ball only on the plane
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Deactivate the rotating cubes if we collide with it
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            //increase the count when we pick up a box
            count++;
            SetCountText(countText, count);
        }
        
    }

    private void SetCountText(Text text, int count)
    {
        text.text = $"Score: {count.ToString()}";
        if(count >= 8)
        {
            SetWinText(winText, "You Win!");
        }
    }

    private void SetWinText(Text winText, string message)
    {
        winText.text = message;
    }
}
