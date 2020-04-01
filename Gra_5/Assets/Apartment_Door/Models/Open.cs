using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    public Animator anim;
    private int count;

    void Start()
    {
        anim = GameObject.Find("Aparment_Door").GetComponent<Animator>();
        anim.SetBool("isOpen", false);
        count = 0;
    }

    void OnTriggerEnter(Collider col)
    {
        count += 1;
        this.gameObject.SetActive(false);
        anim.SetBool("isOpen", true);
    }

    void OnTriggerExit(Collider col)
    {
        anim.SetBool("isOpen", false);
    }
}
