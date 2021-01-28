using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{

    PlayerHealth health;

    Inventory inv;
   
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Heal()
    {
        inv = FindObjectOfType<Inventory>();
        health = FindObjectOfType<PlayerHealth>();

        health.HealDamage(25);

        /*
        foreach (var i in inv.items[])
        {
            //ouai voila quoi faut remettre la valeur a 0 tu va pas m'emmerder'.
        }
        */

        Destroy(this.gameObject);
    }
}
