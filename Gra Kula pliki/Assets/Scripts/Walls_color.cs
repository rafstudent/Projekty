using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls_color : MonoBehaviour
{
    MeshRenderer kolor_3;

    void Start()
    {
        kolor_3 = GetComponent<MeshRenderer>();
        kolor_3.material.color = Color.green;
    }

    void Update()
    {
        
    }
}
