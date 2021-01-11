using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string FirstLevel;
    public string Credits;
    public string Menu;

    public void LoadFirstLevel()
    {
        SceneManager.LoadScene(FirstLevel);
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene(Credits);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(Menu);
    }
}
