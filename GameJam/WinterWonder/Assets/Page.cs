using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page : MonoBehaviour
{

    [Header("Interact")]
    public Transform checkPos;
    public float checkRadius;
    public LayerMask whatIsPlayer;
    bool isPlayerNear;
    public GameObject interactObj;

    // Start is called before the first frame update
    void Start()
    {
        if(ObjectiveManager.instance.objectiveNumber > 0)
        {
            Destroy(gameObject);
        }

        interactObj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        isPlayerNear = Physics2D.OverlapCircle(checkPos.position, checkRadius, whatIsPlayer);

        if (isPlayerNear)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //objective 0
                AudioManagerCS.instance.Play("itemget");
                GameManager.instance.QuestInfo("[ Obtained - A new song, check song book... ]");
                GameManager.instance.questInfoCanvas.SetActive(true);
                ObjectiveManager.instance.ObjectiveCompleted();
                Destroy(gameObject);
            }

            interactObj.SetActive(true);
        }
        else
        {
            interactObj.SetActive(false);
        }


    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(checkPos.position, checkRadius);
    }
}
