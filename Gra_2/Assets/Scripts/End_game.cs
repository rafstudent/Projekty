using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_game : MonoBehaviour
{
    private int count;

    void Start()
    {
        count = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count += 1;
            if (count >= 20)
            {
                Application.Quit();
            }
        }
        else if (other.gameObject.tag == "PickUp_2")
        {
            other.gameObject.SetActive(false);
            count += 3;
            if (count >= 20)
            {
                Application.Quit();
            }
        }

    }
}