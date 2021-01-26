using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    GameObject targetObject;
    Transform target;

    public float smoothTime = 0.25f;
    Vector3 offset;
    Vector3 velocity;

    void Start()
    {
        offset = transform.position - target.position;
        velocity = Vector3.zero;
    }

    void Update()
    {
        if (targetObject == null)
        {
            targetObject = GameObject.FindWithTag("Player");
            target = targetObject.transform;
        }

        transform.position = new Vector3 (target.position.x, target.position.y, -10f);

        //transform.position = Vector3.SmoothDamp( transform.position, target.position + offset, ref velocity, smoothTime );
    }
}
