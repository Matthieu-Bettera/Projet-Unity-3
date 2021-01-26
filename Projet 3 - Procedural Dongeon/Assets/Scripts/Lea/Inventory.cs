using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Static inventory
    public static Inventory current;

    // list numbers of items possible
    public int[] items;

    // list numbers of slots 
    public GameObject[] slots;


    private void Awake()
    {
        // Every inventory create in the scenery is the exact same as this one --> there is only one !
        current = this;
    }
}
