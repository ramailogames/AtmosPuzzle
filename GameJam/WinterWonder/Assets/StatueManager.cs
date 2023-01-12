using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueManager : MonoBehaviour
{
    public static StatueManager instance;

    public List<Statue> statueOrder = new List<Statue>();
    public List<Statue> statues = new List<Statue>();
    int currentCompareNumber = 0;

    private void Awake()
    {
        instance = this;
    }
    public void Compare(Statue statue)
    {
        if(ObjectiveManager.instance.objectiveNumber >= 3)
        {
            return;
        }
        if (statue == statueOrder[currentCompareNumber])
        {
            AudioManagerCS.instance.Play("statue");
           
            currentCompareNumber++;
            statue.vfx.SetActive(true);
            Debug.Log("Next");

        }
        else
        {
            currentCompareNumber = 0;
            AudioManagerCS.instance.Play("error");
            for (int i = 0; i < statues.Count; i++)
            {
                statues[i].vfx.SetActive(false);
            }
        }

        if (currentCompareNumber >= 3)
        {
            Invoke("CompleteObjective", 1f);
            
        }


       
    }

    void CompleteObjective()
    {
        AudioManagerCS.instance.Play("objectiveCompleted");
        GameManager.instance.QuestInfo("[ Obtained - A new song, check song book... ]");
        GameManager.instance.questInfoCanvas.SetActive(true);
        ObjectiveManager.instance.ObjectiveCompleted();
    }
}
