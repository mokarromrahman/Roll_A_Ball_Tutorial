using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //rotate the transform 
        //* Time.deltaTime ensures that the pick up object is 
        //frame rate independent
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);


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
