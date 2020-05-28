using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bieg_skrypt : MonoBehaviour
{
    public int speed_1 = 15;
    private int count;

    void Start()
    {
        count = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            count += 1;

            if (count >= 4)
            {
                Application.Quit();
            }
        }
    }

    void Update()
    {
        if (Input.GetKey("e"))
            transform.Translate(0, 0, speed_1 * Time.deltaTime);
    }
}

