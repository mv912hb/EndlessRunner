using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody rb;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void FixedUpdate() 
    {      
        if (Input.GetKey((KeyCode.D)) || Input.GetKey(KeyCode.RightArrow)) 
        {
            rb.AddForce(10, 0, 0);
        }
        if (Input.GetKey((KeyCode.A)) || Input.GetKey(KeyCode.LeftArrow)) 
        {
            rb.AddForce(-10, 0, 0);
        }
    }
}
