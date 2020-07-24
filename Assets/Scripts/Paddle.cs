using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float paddleSpeed = 0.25f;
    private Vector3 playerPos = new Vector3(0, 0.25f, 4.7f);

    void Update()
    {
        float xPos = transform.position.x - (Input.GetAxis("Horizontal") * paddleSpeed);
        playerPos = new Vector3(Mathf.Clamp(xPos, -3.95f, 3.95f), 0.25f, 4.7f);
        transform.position = playerPos;
    }
}
