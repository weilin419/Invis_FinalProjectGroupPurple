using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BronchoscopyPlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 8f;

    Vector3 velocity;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        //float z = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y ;

        controller.Move(move * speed * Time.deltaTime);

        controller.Move(velocity * Time.deltaTime);
    }
}
