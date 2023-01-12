using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance;
    private void Awake()
    {
        instance = this;
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void PlayLoad()
    {
        AudioManagerCS.instance.Play("statue");
    }
}
