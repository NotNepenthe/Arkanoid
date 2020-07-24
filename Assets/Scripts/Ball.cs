using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballInitialVelocity = 60f;
    private Rigidbody rb;
    private bool ballInPlay;
    private float height = -0.38f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ballInPlay == false)
        {
            transform.parent = null;
            ballInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(ballInitialVelocity, height, ballInitialVelocity));
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            transform.parent = null;
            rb.AddForce(new Vector3(ballInitialVelocity, height, ballInitialVelocity));
        }
    }
}
