using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Elevator : MonoBehaviour
{

    private Rigidbody2D rb;

    private bool gas;
    private bool gas2;

    public Transform StartMarker;
    public Transform EndMarker;

    public float speed = 1.0F;
    
    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.
    private float journeyLength;

    private Touch theTouch;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        gas = false;
        gas2 = false;

         // Keep a note of the time the movement started.
        startTime = Time.time;

        // Calculate the journey length.
        journeyLength = Vector3.Distance(StartMarker.position, EndMarker.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            gas = true;
        }
        else {
            gas = false;
        }
        // Mobile touch inputs
        if (Input.touchCount > 0)
        {
            Debug.Log("Touch detected!");
            theTouch = Input.GetTouch(0);
            if (theTouch.phase == TouchPhase.Began)
            {
                gas = true;
            }
            else if (theTouch.phase == TouchPhase.Ended)
            {
                gas = false;
            }
        }
    }

    private void FixedUpdate() {
        if (gas) {
            if (gas2) {
                // Keep a note of the time the movement started.
                startTime = Time.time;
                // Calculate the journey length.
                journeyLength = Vector3.Distance(StartMarker.position, EndMarker.position);
                
                gas2 = false;
            }
            
            // Distance moved equals elapsed time times speed..
            float distCovered = (Time.time - startTime) * speed;
            // Fraction of journey completed equals current distance divided by total distance.
            float fractionOfJourney = distCovered / journeyLength;

            // Set our position as a fraction of the distance between the markers.
            transform.position = Vector3.Lerp(StartMarker.position, EndMarker.position, fractionOfJourney);
        }
        else {
            gas2 = true;
        }
    }
}
