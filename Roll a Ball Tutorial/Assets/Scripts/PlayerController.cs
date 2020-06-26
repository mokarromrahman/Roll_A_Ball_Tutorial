using Packages.Rider.Editor.PostProcessors;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Called before rendering a frame
    //this is where most of the game code will go
    //private void Update()
    //{
    //don't need this 
    //}

    public float speed;

    private Rigidbody rb;
    private void Start()
    {
        //initialize the ball rigidbody
        rb = GetComponent<Rigidbody>();
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
}
