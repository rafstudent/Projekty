using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject Directional_Light;
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            Directional_Light.GetComponent<Light>().color = Color.blue;
            this.gameObject.SetActive(false);
        }
    }
}
