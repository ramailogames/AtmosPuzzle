using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note : MonoBehaviour
{
    public int noteNumber;
    
    public void HitNote()
    {
        //fill note in piano
        FindObjectOfType<Piano>().FillNote(this);

    }
}
