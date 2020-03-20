using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupcoin : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag ("Player"))
        {
            Destroy(this.gameObject);
            Debug.Log("Coin was picked up");
        }
    }
}
