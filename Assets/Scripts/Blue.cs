using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour {

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
            if (x == 5)
            {
                Destroy(gameObject);
            }
        }
    }
}
