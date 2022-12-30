using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    public static ObjectiveManager instance;

    [Header("Objectives")]
    public int objectiveNumber;

    private void Awake()
    {
        instance = this;
        objectiveNumber = PlayerPrefs.GetInt("objectiveNumber");
    }

    public void ObjectiveState()
    {
        switch (objectiveNumber)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;



        }
    }

    public void ObjectiveCompleted()
    {
        objectiveNumber++;
        PlayerPrefs.SetInt("objectiveNumber", objectiveNumber);
    }
}
