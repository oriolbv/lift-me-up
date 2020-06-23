using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{

    private Rigidbody2D rb;
    private Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        transform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            transform.Translate(new Vector2(0, 5f) * Time.deltaTime);
        }
        
        // if () 
        // {    
        //     // transform.position = new Vector2(transform.position.x, transform.position.y + 1f);
        //     // rb.AddForce(new Vector2(0f, transform.up.y * 200), ForceMode2D.Force);
        // }
    }
}
