using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasPause : MonoBehaviour
{
    private void OnEnable()
    {
        GameManager.instance.canMove = false;
    }

    private void OnDisable()
    {
        GameManager.instance.canMove = true;
    }
}
