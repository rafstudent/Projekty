using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruch : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey("w"))
        {
            anim.SetBool("przycisk", true);
        }
        else
        {
            anim.SetBool("przycisk", false);
        }
    }
}
