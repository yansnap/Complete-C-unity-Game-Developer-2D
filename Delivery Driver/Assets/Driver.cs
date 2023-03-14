using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float steerSpeed = 1;
    [SerializeField] private float moveSpeed = 0.01f;
    void Start()
    {
        
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed;

        transform.Rotate(0,0, steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
