using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int speed = 5;
    private int count;
    public GameObject Capsule;

    void Start()
    {
        count = 0;
        Capsule = GameObject.Find("Capsule");
        Capsule.gameObject.SetActive(false);
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
        if (Input.GetKey("w"))
            transform.Translate(0, 0, speed * Time.deltaTime);
        if (Input.GetKey("s"))
            transform.Translate(0, 0, -speed * Time.deltaTime);
        if (Input.GetKey("a"))
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        if (Input.GetKey("d"))
            transform.Translate(speed * Time.deltaTime, 0, 0);
        
        if (Input.GetKey("f"))
        {
            Capsule.gameObject.SetActive(false);
        }

        if (Input.GetKey("g"))
        {
            Capsule.gameObject.SetActive(true);
        }

    }
}

