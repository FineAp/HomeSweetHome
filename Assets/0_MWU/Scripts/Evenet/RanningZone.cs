using System.Collections;
using UnityEngine;

public class RanningZone : MonoBehaviour
{
    public GameObject ranning;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ranning.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ranning.SetActive(false);
        }
    }
}
