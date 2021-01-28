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

        if(timer >= 2.5f)
        {
            this.gameObject.SetActive(false);
        }
    }
}
