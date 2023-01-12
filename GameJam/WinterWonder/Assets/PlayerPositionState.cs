using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionState : MonoBehaviour
{
   
    public GameObject point1, point2;

    private void Start()
    {

        if(ObjectiveManager.instance.objectiveNumber >= 2)
        {
            point2.SetActive(true);
            return;
        }

        point1.SetActive(true);
    }
}
