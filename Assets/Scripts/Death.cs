using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public int x;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            x++;
            Destroy(gameObject);
            if (x==1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            } else if (x==2)
            {
                if(Input.GetKeyDown(KeyCode.Escape))
                {
                    Application.Quit();
                }
            }

        }
    }
}
