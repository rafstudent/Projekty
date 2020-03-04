using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCapsule : MonoBehaviour
{
    MeshRenderer kolor_2;

    void Start()
    {
        kolor_2 = GetComponent<MeshRenderer>();
        kolor_2.material.color = Color.red;
    }

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
