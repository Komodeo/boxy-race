﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variables
    private float speed = 15f;
    public float turnSpeed = 75f;
    private float horizontalInput;
    private float forwardInput;
    public string verticalAxis;
    public string horizontalAxis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move vehicle forward and back
        forwardInput = Input.GetAxis(verticalAxis);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotate vehicle
        horizontalInput = Input.GetAxis(horizontalAxis);

        // Reverse rotation when vehicle is backing up
        if (forwardInput < 0)
        {
            horizontalInput = horizontalInput * -1;
        }

        // Disallow rotation when vehicle is stationary
        if (forwardInput == 0)
        {
            horizontalInput = 0;
        }

        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        
    }
}
