using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public EventManager eventM;
    public float rotSpeed = 50f;
    public float rot;
    public GameObject sound;

    // private bool isDoor= false;
    
    // Start is called before the first frame update
    void Update()
    {
        if(eventM.ispz_1)
        {
            float currentRot = transform.eulerAngles.z;

            if (currentRot > rot)
            {
                // 회전
                float newRotation = Mathf.MoveTowardsAngle(currentRot, rot, rotSpeed * Time.deltaTime);
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, newRotation);
            }
            sound.SetActive(true);
            Invoke("Delay", 0.8f);
        }
        
    }

    void Delay()
    {
        sound.SetActive(false);
    }



}
