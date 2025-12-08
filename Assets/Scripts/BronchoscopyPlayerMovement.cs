using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BronchoscopyPlayerMovement : MonoBehaviour
{
    // Public the characterController to assign the script to it.
    public CharacterController controller;

    // Public Speed for movement
    public float speed = 8f;

    // Velocity can be defined if needed
    //Vector3 velocity;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get inputs of horizaontals, it will be controlled by inputs of A and D.
        float x = Input.GetAxis("Horizontal");
        // Get inputs of verticals, t will be controlled by inputs of W and S.
        float y = Input.GetAxis("Vertical");

        // Combination vector of x (horizontal) and y (vertical) direction.
        Vector3 move = transform.right * x + transform.forward * y ;

        // Movement calculation = move (vector) * speed * time
        controller.Move(move * speed * Time.deltaTime);

        // Movement of Velocity can be defined if needed
        //controller.Move(velocity * Time.deltaTime);
    }
}
