﻿using System.Collections;

using UnityEngine;

public class controller : MonoBehaviour
{
    private Rigidbody rb;
    //private float movimiento;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement);
    }
}

