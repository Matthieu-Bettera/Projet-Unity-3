using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitSeconds : MonoBehaviour
{

    float timer;

    void Start()
    {
        timer = 0;
    }


    void Update()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);

        if(timer >= 2.5f)
        {
            this.gameObject.SetActive(false);
        }
    }
}
