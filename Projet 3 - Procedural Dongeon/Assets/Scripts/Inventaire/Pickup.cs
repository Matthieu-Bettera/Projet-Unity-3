using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    public GameObject item;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            // spawn the item at the first slot available 
            
            for (int i = 0; i < Inventory.current.items.Length; i++)
            {

                if (Inventory.current.items[i] == 0) // if the slot is empty
                {
                    Inventory.current.items[i] = 1; // make the slot considered full

                    Instantiate(item, Inventory.current.slots[i].transform, false); // spawn the button

                    Destroy(gameObject);

                    break;
                }
            }
        }
        
    }
}
