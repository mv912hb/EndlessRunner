using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingCapsule : MonoBehaviour
{
    public int capsules;

    private void OnTriggerEnter(Collider capsule) 
    {
        if(capsule.gameObject.tag == "Capsule")
        {
            Debug.Log("Collected!");
            capsules += 1;
            capsule.gameObject.SetActive(false);
        }    
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
