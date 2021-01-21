using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour {

    // number of the slot itself
    public int index;

    public void Cross()
    {
        // Find the object in the slot
        foreach (Transform child in transform)
        {
            // Delete this object
            GameObject.Destroy(child.gameObject);
        }
    }
}
