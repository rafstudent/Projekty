using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Color : MonoBehaviour
{
    MeshRenderer kolor_1;

    void Start()
    {
        kolor_1 = GetComponent<MeshRenderer>();
        kolor_1.material.color = Color.yellow;
    }

    void Update()
    {
        
    }
}
