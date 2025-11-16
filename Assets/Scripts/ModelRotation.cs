using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ModelRotation : MonoBehaviour
{
    public float xRot = 0.0f;
    public float yRot = 0.0f;
    public Vector3 eulerRot;

    //This script was taken from and reused my diorama formative assessment.
    //Script is from video 6.2 Implementing simple interactions with Input and Transform Classes - Part 2 - Rotation by Matt on Canvas
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //This will allow for rotation about the x axis
        if (Input.GetKey(KeyCode.UpArrow))
        {
            xRot = -1.0f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            xRot = 1.0f;
        }
        else
        {
            xRot = 0.0f;
        }

        //This will allow for rotation about the y axis
        if (Input.GetKey(KeyCode.RightArrow))
        {
            yRot = -1.0f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            yRot = 1.0f;
        }
        else
        {
            yRot = 0.0f;
        }
        eulerRot = new Vector3(xRot, yRot, 0.0f);
        transform.Rotate(eulerRot, Space.Self);

    }


 
        
    
}