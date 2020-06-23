using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{

    private Rigidbody2D rb;
    private Transform transform;

    private bool gas;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        transform = this.GetComponent<Transform>();
        gas = false;
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
            transform.Translate(new Vector2(0, 5f) * Time.deltaTime);
        }
    }
}
