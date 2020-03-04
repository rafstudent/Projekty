using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCylinder : MonoBehaviour
{
    MeshRenderer kolor_1;

    void Start()
    {
        kolor_1 = GetComponent<MeshRenderer>();
        kolor_1.material.color = Color.yellow;
    }

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);    
    }
}
