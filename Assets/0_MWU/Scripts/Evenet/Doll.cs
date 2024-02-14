using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doll : MonoBehaviour
{
    public EventManager eventM;
    public GameObject hammerSound;
    public GameObject bgm;

    public GameObject diary6;
    public GameObject hospital;

    private int count = 0;

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Hammer"))
        {
            hammerSound.SetActive(true);
            Invoke("Delay", 1f);

            count ++;
            print(count);

            if(count == 3)
            {
                eventM.isDream = true;
                count = 5;
                bgm.SetActive(false);
                
                diary6.SetActive(false);
                hospital.SetActive(true);
            }

        }
    }

    void Delay()
    {
        hammerSound.SetActive(false);
    }
}
