using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] private float destroyDelay = 0.1f;
    private bool hasPackage;

    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log(other);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("picked up package");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
            
        }

        if (other.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("delivered package");
            hasPackage = false;
        }
    }
}
