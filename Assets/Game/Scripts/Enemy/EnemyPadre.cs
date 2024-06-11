using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyPadre : MonoBehaviour
{
    public float currentHealth;

  
    public GameObject deathEffect;
    public Transform deathEffectPoint;

    public GameObject fireEfectBoss;
    public Transform fireEfectBossPoint;

   

   

    public void TakeDamage(float damage)
    {
      
        currentHealth -= damage;

    }

   
    protected void Die()
    {
        if (deathEffect != null)
        {
            Instantiate(deathEffect, deathEffectPoint.position, deathEffectPoint.rotation);
            Debug.Log("animacion muerte instanciada");
        }

        
        Destroy(gameObject);
    }

    protected void DamageBoss()
    {
       
        if( currentHealth <= 50 )
        {
            Instantiate(fireEfectBoss, fireEfectBossPoint.position, fireEfectBossPoint.rotation);
            
        }
    }


}
