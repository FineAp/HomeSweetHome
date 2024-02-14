using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    public GameObject news1;

    public EventManager eventM;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Trick"));
        {
            news1.SetActive(true);
            eventM.ispz_1 = true;
            Invoke("Delay",1.5f);
        }
    }

    void Delay()
    {
        eventM.ispz_1 = false;
        Destroy(this.gameObject);
    }

}
