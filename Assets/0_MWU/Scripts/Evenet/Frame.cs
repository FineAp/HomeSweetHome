using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frame : MonoBehaviour
{
    public EventManager eventM;
    public Transform targetPos;

    public GameObject fram_Canvas;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (eventM.isDrop)           
        // eventM.isDrop이 true일 때 rb.isKinematic를 false로 설정하여 Rigidbody 활성화
        {
            rb.isKinematic = false;
            rb.position = targetPos.position;
            Invoke("Delay", 1f);
        }   
    }

    void Delay()
    {
        eventM.isDrop = false;
        fram_Canvas.SetActive(true);
    }
}
