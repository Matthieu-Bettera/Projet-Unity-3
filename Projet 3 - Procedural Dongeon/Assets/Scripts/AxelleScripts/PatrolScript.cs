﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolScript : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;


    public Transform moveSpots;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY; 
    
    public GameObject projectile;
    private float timeS;
    public float startTimeS;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        moveSpots.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));

        timeS = startTimeS;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, moveSpots.position) < 0.2f)
        {
            if (waitTime <= 0)

                moveSpots.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
            waitTime = startWaitTime;
        }

        else
        {
            waitTime -= Time.deltaTime;
        }


        if (timeS <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeS = startTimeS;
        }

        else
        {
            timeS -= Time.deltaTime;
        }
    }


}