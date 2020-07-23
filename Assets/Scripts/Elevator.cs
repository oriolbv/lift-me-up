using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    // Rigidbody 
    private Rigidbody2D rb;

    // Force
    public float elevatorForce = 75.0f;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() 
    {
        bool elevatorActive = Input.GetButton("Fire1");
        if (elevatorActive)
        {
            rb.AddForce(new Vector2(0, elevatorForce));
        }
    }
}
