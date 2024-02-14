using UnityEngine;

public class Last : MonoBehaviour
{
    public EventManager eventM;
    public GameObject player;
    public GameObject ghost;
    public GameObject light;

    public GameObject player2;

    void Update()
    {
        if(eventM.isChange)
        {
            player.SetActive(false);
            player2.SetActive(true);
            light.SetActive(false);

            Invoke("Delay", 3f);
            eventM.isChange = false;

        }
    }

    void Delay()
    {
        ghost.SetActive(true);
    }
}
