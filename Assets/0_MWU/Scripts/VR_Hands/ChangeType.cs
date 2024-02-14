using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChangeType : MonoBehaviour
{
    public ActionBasedSnapTurnProvider snapTurn;
    public ActionBasedSnapTurnProvider continousTurn;

    public void SetTypeFromIndex(int index)
    {
        if(index == 0)
        {
            snapTurn.enabled = false;
            continousTurn.enabled = true;
        }

        else if(index == 1)
        {
            snapTurn.enabled = true;
            continousTurn.enabled = false;
        }
    }
}
