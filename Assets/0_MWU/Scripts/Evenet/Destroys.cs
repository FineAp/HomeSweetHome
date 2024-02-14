using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroys : MonoBehaviour
{
    public float time = 20f;

    void Start()
    {
        Invoke("Delay", time);
    }

    void Delay()
    {
        gameObject.SetActive(false);
    }
}
