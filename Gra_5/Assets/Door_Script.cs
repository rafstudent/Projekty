using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Script : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider col)
    {
        anim.SetBool("isOpen", true);
    }

void OnTriggerExit(Collider col)
    {
        anim.SetBool("isOpen", false);
    }
}
