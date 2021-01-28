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

    void Start()
    {
        //Get all the slots
        //Pas obti du tout mais je n'arrive pas a le faire avec un for
        slots[0] = GameObject.Find("Slot 1");
        slots[1] = GameObject.Find("Slot 2");
        slots[2] = GameObject.Find("Slot 3");

    }
}
