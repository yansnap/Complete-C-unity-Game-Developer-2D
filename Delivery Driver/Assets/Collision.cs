using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("U collied a object!");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("What was that?!");
    }
}
