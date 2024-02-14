using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastDoor : MonoBehaviour
{
    public EventManager eventM;

    public GameObject sound;

    public float rotSpeed = 50f;
    public float rot;

    // private bool isDoor= false;
    
    // Start is called before the first frame update
    void Update()
    {
        if(eventM.lastOpenDoor)
        {
            float currentRot = transform.eulerAngles.z;

            if (currentRot > rot)
            {
                // 회전
                float newRotation = Mathf.MoveTowardsAngle(currentRot, rot, rotSpeed * Time.deltaTime);
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, newRotation);
            }

            Invoke("Delay", 2f);
            sound.SetActive(true);
            Invoke("SoundDelay", 0.8f);

        }
        
    }

    void Delay()
    {
        eventM.lastOpenDoor = false;
    }

    void SoundDelay()
    {
        sound.SetActive(false);
    }



}
