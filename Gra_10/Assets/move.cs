using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public int speed = 5;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey("d"))
            transform.Translate(0, 0, speed * Time.deltaTime);
        if (Input.GetKey("a"))
            transform.Translate(0, 0, -speed * Time.deltaTime);
        if (Input.GetKey("w"))
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        if (Input.GetKey("s"))
            transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
