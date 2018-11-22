using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float xMin, xMax, zMin, zMax;
    // Use this for initialization
    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = movement * speed;

        rb.position = new Vector3
            (
            Mathf.Clamp(rb.position.x, xMin ,xMax),
            0.0f,
            Mathf.Clamp(rb.position.z, zMin , zMax)
            );
            
	}
}
