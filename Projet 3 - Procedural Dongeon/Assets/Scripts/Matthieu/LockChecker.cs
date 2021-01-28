using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockChecker : MonoBehaviour
{
    public RoomTypes type;
    public GameObject door;

    bool alreadyLocked = false;

    private void Update()
    {
        if (type.isLocked == true)
        {
            if(alreadyLocked == false)
            {
                GameObject instance = (GameObject)Instantiate(door, transform.position, transform.rotation);
                instance.transform.parent = transform;

                alreadyLocked = true;
            }

        }
    
    }
}
