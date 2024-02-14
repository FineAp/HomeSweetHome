using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleZone : MonoBehaviour
{
    public GameObject people;
    public EventManager eventM;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("People"))
        {
            other.gameObject.SetActive(false);
            people.SetActive(true);
            eventM.isPeoplePic = true;
            

        }
    }
}
