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

    [Header("Note List")]
    int currentNoteCompareNumber = 0;
    public List<note> currentNoteList = new List<note>();
    public List<note> objectiveNote1 = new List<note>();
    public List<note> objectiveNote2 = new List<note>();
    public List<note> objectiveNote3 = new List<note>();
  


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

   
    public void FillNote(note _note)
    {
        

        if(ObjectiveManager.instance.objectiveNumber == 1)
        {
            if (_note == objectiveNote1[currentNoteCompareNumber])
            {
                currentNoteList.Add(_note);
                currentNoteCompareNumber++;

                if (currentNoteCompareNumber >= 4)
                {
                    pianoCanvas.SetActive(false);
                    currentNoteList.Clear();
                    currentNoteCompareNumber = 0;
                    AudioManagerCS.instance.Play("objectiveCompleted");
                    ObjectiveManager.instance.ObjectiveCompleted();
                    Invoke("ThemeSong", 1f);
                }
            }
            else
            {
                currentNoteList.Clear();
                currentNoteCompareNumber = 0;
            }
        }
        
      
        
    }

    void ThemeSong()
    {
        AudioManagerCS.instance.Play("theme");
    }

}
