using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject target;
    Vector3 offset = new Vector3(0, 1, -5);

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = target.transform.position + offset;
    }
}