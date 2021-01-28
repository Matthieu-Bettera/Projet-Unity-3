using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{

    PlayerHealth health;
   
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Heal()
    {
        health = FindObjectOfType<PlayerHealth>();

        health.HealDamage(25);
    }
}
