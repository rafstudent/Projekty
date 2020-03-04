using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    private int count;
    MeshRenderer kolor;

    void Start()
    {
        kolor = GetComponent<MeshRenderer>();
        kolor.material.color = Color.blue;
        count = 0;   
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count += 1;

            if (count >= 9) {
                Application.Quit();
            }
        }
        else if (other.gameObject.tag == "PickUp_2")
        {
            other.gameObject.SetActive(false);
            count += 3;
            if (count >= 9)
            {
                Application.Quit();
            }
        }

    }

}
