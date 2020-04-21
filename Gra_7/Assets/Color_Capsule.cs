using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Capsule : MonoBehaviour
{

    MeshRenderer kolor_5;
    public Color brazowy = new Color(255F, 165F, 4F, 0.5F);

    void Start()
    {
        kolor_5 = GetComponent<MeshRenderer>();
        kolor_5.material.color = brazowy;
    }

    void Update()
    {
        
    }
}
