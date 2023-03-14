using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControls : MonoBehaviour
{
    public float acc = 0.01f;
    public float jump = 5;
    public float forward = 10;
    
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {// otan prosueto + tote exoume epitaxinsi, diaforetika exoyme omalh kinhsh
        rb.velocity += new Vector3(Input.GetAxis("Vertical") * -acc, 0, Input.GetAxis("Horizontal") * acc); 
       
    }

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            rb.velocity = new Vector3(0, jump, forward);
        }

        if (Input.GetButtonDown("Fire2"))
        {
            rb.velocity = new Vector3(0, jump, -forward);
        }
    }
}
