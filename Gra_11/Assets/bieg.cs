using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bieg : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey("e"))
        {
            anim.SetBool("przycisk_1", true);
        }
        else
        {
            anim.SetBool("przycisk_1", false);
        }
    }
}
