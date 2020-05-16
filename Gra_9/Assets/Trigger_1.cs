using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_1 : MonoBehaviour
{
    public GameObject Directional_Light;
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            Directional_Light.GetComponent<Light>().color = Color.yellow;
            this.gameObject.SetActive(false);
        }
    }
}
