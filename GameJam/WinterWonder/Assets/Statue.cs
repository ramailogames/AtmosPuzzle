using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : MonoBehaviour
{
   
    public LayerMask whatIsPlayer;
    public float checkRadius;
    public Transform checkPos;
    public GameObject interactActionPng;
    public GameObject vfx;
    private void Start()
    {
        if(ObjectiveManager.instance.objectiveNumber >= 3)
        {
            vfx.SetActive(true);
        }
    }
    private void Update()
    {
        Collider2D playerCheck = Physics2D.OverlapCircle(checkPos.position, checkRadius, whatIsPlayer);

        if (playerCheck != null)
        {
            interactActionPng.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                StatueManager.instance.Compare(this);
            }
        }
        else
        {
            interactActionPng.SetActive(false);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(checkPos.position, checkRadius);
    }


}
