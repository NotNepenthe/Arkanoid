﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class White : MonoBehaviour
{
    public int x;
    void Start()
    {
        x = 0;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            x++;
            if (x == 3)
            {
                Destroy(gameObject);
            }
        }
    }
}
