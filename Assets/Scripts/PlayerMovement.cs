using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 1500f;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

        if(rb.position.y < -1f)
        {
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}
