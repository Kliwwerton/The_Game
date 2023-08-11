using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playr_movement : MonoBehaviour
{
    public Rigidbody rb;
    public float strefSpeed = 500f;
    public float runSpeed = 500f;
    public float jumpForce = 15f;

    protected bool strafeLeft = false;
    protected bool strafeRight = false;
    protected bool doJump = false;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            strafeRight = true;
        }
        else
        { 
            strafeRight = false;
        }

        if (Input.GetKey("a")) 
        {
            strafeLeft = true;
        }
        else 
        { 
            strafeLeft = false;
        }

        if (Input.GetKeyDown("space"))
        { 
            doJump = true;
        }
        else
        {
            doJump = false;
        }
    

    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, runSpeed * Time.deltaTime);
    }
}
