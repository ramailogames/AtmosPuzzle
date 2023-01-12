using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public GameObject introDialogue;
    public GameObject skipBtn;

    private void Start()
    {
        Invoke("StartGame", 3f);
    }
 
    void StartGame()
    {
        skipBtn.SetActive(true);
    }

    public void Skip()
    {
        AudioManagerCS.instance.Play("start");
        introDialogue.SetActive(false);
    }
}
