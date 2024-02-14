using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    public GameObject player;
    public GameObject target;
    public GameObject particle;

    public EventManager eventM;
    
    public GameObject newBGm;

    void Update()
    {
        if(eventM.clear)
        {
            player.SetActive(false);
            target.SetActive(true);
            particle.SetActive(true);

            newBGm.SetActive(true);
            Invoke("Next", 10f);
            eventM.clear = false;
            
        }
    }

    void Next()
    {
        SceneManager.LoadScene("1___Clear___");
    }
}
