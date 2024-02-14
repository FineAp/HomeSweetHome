using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public EventManager eventM;
    
    public GameObject news2;
    public GameObject book;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Trick"))
        {
            news2.SetActive(true);
            eventM.ispz_2 = true;
            Invoke("Dealy", 5f);
            other.gameObject.SetActive(false);
            book.SetActive(true);

        }
        
    }

    void Dealy()
    {
        eventM.isDrop = true;
    }
}
