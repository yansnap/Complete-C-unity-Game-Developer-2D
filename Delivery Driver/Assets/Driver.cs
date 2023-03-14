using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float steerSpeed = 0.1f;
    [SerializeField] private float moveSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        
        transform.Rotate(0,0,steerSpeed);
        transform.Translate(0, moveSpeed, 0);
    }
}
