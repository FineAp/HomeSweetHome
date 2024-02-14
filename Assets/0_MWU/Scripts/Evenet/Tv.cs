using System.Collections;
using UnityEngine;

public class Tv : MonoBehaviour
{
    public GameObject tvRawImg;

    public EventManager eventM;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Hand"))
        {
            tvRawImg.SetActive(true);
            Invoke("DelayTv",2f);
        }
    }

    void DelayTv()
    {
        eventM.isKey = true;
    }

}
