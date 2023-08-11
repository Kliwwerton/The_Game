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
    protected bool strafeUp = false;


    // Update is called once per frame
    void Update()
    {
        
    }
}
