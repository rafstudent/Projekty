using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obroty_2 : MonoBehaviour
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
            anim.SetBool("przycisk_2", true);
        }
        else
        {
            anim.SetBool("przycisk_2", false);
        }
    }
}
