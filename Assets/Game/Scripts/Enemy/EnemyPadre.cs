using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyPadre : MonoBehaviour
{
    public float currentHealth;


    public GameObject deathEffect;
    public Transform deathEffectPoint;

    public GameObject fireEfectBoss;
    public Transform fireEfectBossPoint1;
    public Transform fireEfectBossPoint2;

    protected GameObject FireEfect1;
    protected GameObject FireEfect2;

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
       FireEfect1 = Instantiate(fireEfectBoss, fireEfectBossPoint1.position, fireEfectBossPoint1.rotation);

       FireEfect2 = Instantiate(fireEfectBoss, fireEfectBossPoint2.position, fireEfectBossPoint2.rotation);

    }

}
