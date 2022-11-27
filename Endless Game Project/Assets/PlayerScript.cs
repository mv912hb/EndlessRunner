using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void FixedUpdate() 
    {
        rb.AddForce(0, 0, 1000 * Time.deltaTime);   
        if (Input.GetKey((KeyCode.D)) || Input.GetKey(KeyCode.RightArrow)) 
        {
            rb.transform.Translate(0.3f, 0, 0);
        }
    }
}
