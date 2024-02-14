using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    private Animator anim;

    public EventManager eventM;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(eventM.isFadeOut)
        {
            anim.SetTrigger("isFade");
            eventM.isFadeOut = false;
        }
    }
}
