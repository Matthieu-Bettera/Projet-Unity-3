using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public Healthbar healthbar;

    public float maxHealth;
    public float health;

    public float smoothing = 5f;

   

  


    private void Start()
    {
        healthbar = FindObjectOfType<Healthbar>();

        health = maxHealth;
    }

   public void TakeDamage(float damage)
    {
        health -= damage;
    }

    public void HealDamage(float heal)
    {
        health += heal;
    }

    private void Update()
    {

    

        if (healthbar.slider.value != health)
        {
            healthbar.slider.value = Mathf.Lerp(healthbar.slider.value, health, smoothing * Time.deltaTime);
        }
    }
}
