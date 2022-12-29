using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    [Header("Interact")]
    public GameObject interactKey;
    public GameObject pianoCanvas;
    public LayerMask whatIsPlayer;
    public float radius;
    public Transform checkPos;
    bool isPlayerNear;
    // Start is called before the first frame update
    void Start()
    {
        interactKey.SetActive(false);
        pianoCanvas.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        isPlayerNear = Physics2D.OverlapCircle(checkPos.position, radius, whatIsPlayer);

        if (isPlayerNear)
        {
            interactKey.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                AudioManagerCS.instance.Play("interact");
                pianoCanvas.SetActive(true);
            }
        }
        else
        {
            interactKey.SetActive(false);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(checkPos.position, radius);
    }
}
