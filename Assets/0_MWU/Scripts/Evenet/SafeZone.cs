using UnityEngine;

public class SafeZone : MonoBehaviour
{
    public GameObject player;
    public GameObject player2;
    public GameObject ghost;
    public GameObject light;

    public EventManager eventM;


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            player2.SetActive(false);
            player.SetActive(true);
            ghost.SetActive(false);
            light.SetActive(true);

            Invoke("Delay", 5f);


        }
    }

    void Delay()
    {
        eventM.ispz_4 = true;
    }

}
