using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public float pzTime = 2f;

    public GameObject puzzle_1;
    public GameObject puzzle_2;
    public GameObject puzzle_3;
    public GameObject puzzle_4;

    public GameObject news3;
    public GameObject diary3;
    public GameObject diary4;
    public GameObject diary5;


    public GameObject key;

    public GameObject DropSound;
    public GameObject fadeOut_Canvas;

    public GameObject hospital;
    public GameObject doll;
    public GameObject hammer;

    public bool ispz_1 = false;
    public bool ispz_2 = false;
    public bool ispz_3 = false;
    public bool ispz_4 = false;

    public bool isKey = false;

    private bool have1 = false;
    private bool have2 = false;
    private bool have3 = false;
    private bool have4 = false;

    // Frame 다시 걸기
    public bool isDrop = false;

    public bool isDogPic = false;
    public bool isPeoplePic = false;

    //For LastRoom;
    public bool lastOpenDoor = false;

    public bool isDream = false;
    public bool isFadeOut = false;

    public bool isChange = false;
    public bool clear = false;

    //sound;

    void Update()
    {
        Puzzle();
        HaveKey();
        FrameDrop();
        Dream();
        Clear();
        
    }

    void Puzzle()
    {
        if(ispz_1)
        {
            puzzle_1.SetActive(true);
            have1 = true;
            Invoke("Delay", pzTime);
        }

        else if(ispz_2)
        {
            puzzle_1.SetActive(true);
            puzzle_2.SetActive(true);
            have2 = true;
            Invoke("Delay", pzTime);
        }

        else if(ispz_3)
        {
            puzzle_1.SetActive(true);
            puzzle_2.SetActive(true);
            puzzle_3.SetActive(true);
            have3 = true;
            Invoke("Delay", pzTime);
        }

        else if(ispz_4)
        {
            puzzle_1.SetActive(true);
            puzzle_2.SetActive(true);
            puzzle_3.SetActive(true);
            puzzle_4.SetActive(true);
            have4 = true;
            Invoke("Delay", pzTime);

            hospital.SetActive(true);
            doll.SetActive(false);
            hammer.SetActive(false);
        }

    }

    void HaveKey()
    {
        if(isKey)
        {
            key.SetActive(true);
            Invoke("IsKeyFalse", 2f);
        }

    }

    void FrameDrop()
    {
        if(isDrop)
        {
            DropSound.SetActive(true);
        }

        if(isDogPic && isPeoplePic)
        {
            ispz_3 = true;
            news3.SetActive(true);
            diary3.SetActive(true);
            diary4.SetActive(true);
            diary5.SetActive(true);
            
            lastOpenDoor = true;
            isDogPic = false;
            isPeoplePic = false;
            

        }
    }

    void Dream()
    {
        if(isDream)
        {
            isFadeOut = true;
            fadeOut_Canvas.SetActive(true);
            Invoke("FadeDelay", 5f);
            Invoke("ChangePlayer", 3f);
            isChange = false;
        }
    }

    void Clear()
    {
        if(have1 && have2 && have3 && have4)
        {
            print("끝이지롱");
            clear = true;
            
        }
    }

    void FadeDelay()
    {
        fadeOut_Canvas.SetActive(false);
        isDream = false;
    }

    void ChangePlayer()
    {
        isChange = true;
        
    }



    //For Delay
    void Delay()
    {
        ispz_1 = false;
        ispz_2 = false;
        ispz_3 = false;
        ispz_4 = false;

        puzzle_1.SetActive(false);
        puzzle_2.SetActive(false);
        puzzle_3.SetActive(false);
        puzzle_4.SetActive(false);
    }

    void IsKeyFalse()
    {
        isKey = false;
    }

}
