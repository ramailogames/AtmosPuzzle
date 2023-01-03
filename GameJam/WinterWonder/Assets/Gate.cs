using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(ObjectiveManager.instance.objectiveNumber == 0)
            {
                GameManager.instance.QuestInfo("[ Luna.. You missed a song page. ]");
                GameManager.instance.questInfoCanvas.SetActive(true);
            }

            if (ObjectiveManager.instance.objectiveNumber == 1)
            {
                GameManager.instance.QuestInfo("[ Luna.. Play the song, Check in songbook.. ]");
                GameManager.instance.questInfoCanvas.SetActive(true);
            }
        }
    }

    /* public float radius;
     public LayerMask whatIsPlayer;


     private void Update()
     {
         if(ObjectiveManager)
         bool isPlayerNear = Physics2D.OverlapCircle(transform.position, radius, whatIsPlayer);

         if (isPlayerNear)
         {

         }
     }
     private void OnDrawGizmosSelected()
     {
         Gizmos.DrawWireSphere(transform.position, radius);
     }*/
}
