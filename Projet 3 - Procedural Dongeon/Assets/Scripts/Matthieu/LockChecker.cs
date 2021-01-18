using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockChecker : MonoBehaviour
{
    public RoomTypes type;
    public GameObject door;

    private void Update()
    {
        if (type.isLocked == true)
        {
            GameObject instance = (GameObject)Instantiate(door, transform.position, transform.rotation);
            instance.transform.parent = transform;
        }
    }
}
