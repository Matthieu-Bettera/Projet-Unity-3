using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splashscreen : MonoBehaviour
{
    
    //Script pour faire un splashscreen

    public float seconds;
    public string Help;


    void Start()
    {
        StartCoroutine(SwitchScene());
    }

    IEnumerator SwitchScene()
    {

        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(Help);
        //Do the thing
    }

}

