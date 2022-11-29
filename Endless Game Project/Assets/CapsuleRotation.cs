using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleRotation : MonoBehaviour
{

    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void FixedUpdate() 
    {
        transform.Rotate(Vector3.left, speed);
    }
}
