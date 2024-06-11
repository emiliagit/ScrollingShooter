using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : EnemyPadre
{
    public GameObject bulletPrefab;
    public Transform firePoint;

    public float bulletSpeed = 5f;

    public float fireRate = 1f;
    private float nextFireTime = 0f;

    bool fireEffectSpawned = false;

    private Transform player;

    void Start()
    {
        currentHealth = 100;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (Time.time > nextFireTime)
        {
            nextFireTime = Time.time + fireRate;
            Shoot();
        }

        if ( currentHealth <= 50 && !fireEffectSpawned)
        {
            DamageBoss();
            fireEffectSpawned = true;
        }

        if(currentHealth <= 0 )
        {
            Die();
            Destroy(FireEfect1);
            Destroy(FireEfect2);
            Debug.Log("smoke desactivado");
        } 
       
    }

    void Shoot()
    {
        Vector2 direction = (player.position - firePoint.position).normalized;
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
        Destroy(bullet, 3f);


    }

}
