using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPadre : MonoBehaviour
{
   
   
  
    public float currentHealth;

  
    public GameObject deathEffect;

    void Start()
    {
    }

    public void TakeDamage(float damage)
    {
      
        currentHealth -= damage;

    }

   
    protected void Die()
    {
      
        if (deathEffect != null)
        {
            Instantiate(deathEffect, transform.position, transform.rotation);
        }

        
        Destroy(gameObject);
    }


}
