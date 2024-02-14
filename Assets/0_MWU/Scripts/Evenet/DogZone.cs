using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogZone : MonoBehaviour
{
    public GameObject dog;

    public EventManager eventM;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Dog"))
        {
            other.gameObject.SetActive(false);
            dog.SetActive(true);
            eventM.isDogPic = true;
        }
    }
}
