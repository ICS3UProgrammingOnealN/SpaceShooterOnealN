using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    public float tumble;

    private Rigidbody rb;

    void start()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * tumble;
    }
}

