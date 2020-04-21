using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obroty_5 : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey("p"))
        {
            anim.SetBool("przycisk", true);
        }
        else
        {
            anim.SetBool("przycisk", false);
        }
    }
}
