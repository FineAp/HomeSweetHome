using UnityEngine;

public class Times : MonoBehaviour
{
    public GameObject type;
    public GameObject win;

    void Start()
    {
        Invoke("Delay", 10f);

    }

    void Delay()
    {
        type.SetActive(true);
        Invoke("Win", 7f);
    }

    void Win()
    {
        win.SetActive(true);

    }
}
