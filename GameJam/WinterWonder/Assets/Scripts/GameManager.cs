using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Gameplays")]
    public GameObject pianoCanvas;
    public GameObject questInfoCanvas;
    public bool canMove = true;

    [Header("Quest-Info")]
    public TextMeshProUGUI questInfoText;


    [Header("SongBook")]
    public GameObject song1;
    public GameObject song2;
    public GameObject song3;
    bool hasOpenedSongBook = true;
    public GameObject songBook;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pianoCanvas.activeInHierarchy)
            {
                //AudioManagerCS.instance.Play("interact");
                pianoCanvas.SetActive(false);
            }

            if (questInfoCanvas.activeInHierarchy)
            {
                //AudioManagerCS.instance.Play("interact");
                questInfoCanvas.SetActive(false);
            }

            if (songBook.activeInHierarchy)
            {
                SongBook();
            }
            
        }


        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SongBook();
        }
    }


    public void QuestInfo(string text_)
    {
        questInfoText.text = text_;
    }


    //objective 1 is for song1, ... , ...
    public void SongBook()
    {
        if(ObjectiveManager.instance.objectiveNumber >= 1)
        {
            song1.SetActive(true);
        }

        if (ObjectiveManager.instance.objectiveNumber == 3) 
        {
            song1.SetActive(true);
        }

        if (ObjectiveManager.instance.objectiveNumber == 4)
        {
            song1.SetActive(true);
        }

        //toogle book
        hasOpenedSongBook = !hasOpenedSongBook;

        if (hasOpenedSongBook)
        {
            songBook.SetActive(false);
        }
        else if (!hasOpenedSongBook)
        {
            songBook.SetActive(true);
        }
    }
}
