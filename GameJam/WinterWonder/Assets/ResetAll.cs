using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAll : MonoBehaviour
{
    private void Awake()
    {
        PlayerPrefs.SetInt("objectiveNumber", 0);
    }
  
}
