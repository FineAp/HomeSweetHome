using System.Collections;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public EventManager eventM;

    public float rotSpeed = 50f;
    public float rot;

    public GameObject door;
    public GameObject sound;

    public bool aroundKey = false;
    
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Key"))
        {
            eventM.key.SetActive(false);
            aroundKey = true;

        }
    }

    void Update()
    {
        if(aroundKey)
        {
            float currentRot = door.transform.eulerAngles.z;

            if (currentRot > rot)
            {
                // 회전
                float newRotation = Mathf.MoveTowardsAngle(currentRot, rot, rotSpeed * Time.deltaTime);
                door.transform.eulerAngles = new Vector3(door.transform.eulerAngles.x, door.transform.eulerAngles.y, newRotation);
            }
            Invoke("Delay", 2f);
            sound.SetActive(true);
            Invoke("SoundDelay", 0.8f);

        }
        
    }

    void Delay()
    {
        aroundKey = false;
    }

    void SoundDelay()
    {
        sound.SetActive(false);
    }

}
