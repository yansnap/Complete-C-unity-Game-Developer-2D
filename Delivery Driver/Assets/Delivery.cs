using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool hasPackage;
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Package"))
        {
            Debug.Log("picked up package");
            hasPackage = true;
            
        }
        
        if (other.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("delivered package");
            hasPackage = false;
        }
    }
}
