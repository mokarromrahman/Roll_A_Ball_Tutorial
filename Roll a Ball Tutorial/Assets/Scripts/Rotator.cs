using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;

public class Rotator : MonoBehaviour
{

    private float time = 0.0f;
    public float interpolationPeriod = 1000.0f;


    // Update is called once per frame
    void Update()
    {
        //rotate the transform 
        //* Time.deltaTime ensures that the pick up object is 
        //frame rate independent
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);

        time += Time.deltaTime;

        if (time >= interpolationPeriod)
        {
            time = 0.0f;

            // execute block of code here
            ChangeColorsDynamic(GetComponent<Renderer>());
            Console.WriteLine("I'm here");
        }
        //ChangeColorsDynamic(GetComponent<Renderer>());
    }

    //Dynamically change colors
    void ChangeColorsDynamic(Renderer renderer)
    {

            if (renderer.material.GetColor("_Color") == Color.red)
            {
                //Call SetColor using the shader property name "_Color" and setting the color to red
                renderer.material.SetColor("_Color", Color.yellow);
            }
            else
            {
                //Call SetColor using the shader property name "_Color" and setting the color to red
                renderer.material.SetColor("_Color", Color.red);
            }
        

    }
}
