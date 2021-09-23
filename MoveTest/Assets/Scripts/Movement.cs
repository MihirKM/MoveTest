using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 20f;
    public float RotSpeed = 1;
    Rigidbody2D myRB;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    private Rigidbody2D GetComponent(object rigidBody2D)
    {
        throw new NotImplementedException();
    }

    // Fixed Update is called 30 times every second
    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // empty vector
        Vector3 direction = Vector3.zero;
        Vector3 rotation = Vector3.zero;

        // grab input
        float rotate = Input.GetAxisRaw("Mouse ScrollWheel");
        //direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        myRB.AddForce(transform.up * direction.y * Speed * Time.deltaTime);
        myRB.AddTorque(rotate * RotSpeed * Time.deltaTime);
        
    }
}
