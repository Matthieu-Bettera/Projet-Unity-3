﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTypes : MonoBehaviour
{
    public int type;
    public bool isLocked = false;

    public void RoomDestruction()
    {
        Destroy(gameObject);
    }
}
