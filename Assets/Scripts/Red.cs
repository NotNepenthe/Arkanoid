using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour
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
            if (x == 4)
            {
                Destroy(gameObject);
            }
        }
    }
}
