using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{

    private Rigidbody2D rb;

    private bool gas;

    public Transform StartMarker;
    public Transform EndMarker;

    public float speed = 1.0F;
    
    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.
    private float journeyLength;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        gas = false;

         // Keep a note of the time the movement started.
        startTime = Time.time;

        // Calculate the journey length.
        journeyLength = Vector3.Distance(StartMarker.position, EndMarker.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            Debug.Log("UP");
            gas = true;
        }
        else {
            Debug.Log("DOWN");
            gas = false;
        }

        
    }

    private void FixedUpdate() {
        if (gas) {
            transform.Translate (Vector3.up * Time.deltaTime * 4f);
        }
    }
}
