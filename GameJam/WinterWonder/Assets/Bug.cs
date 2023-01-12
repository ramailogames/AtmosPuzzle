using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.instance.QuestInfo("I heard... these statues should be touched in a specific order");
            GameManager.instance.questInfoCanvas.SetActive(true);
            GameManager.instance.canMove = false;
        }
    }
}
