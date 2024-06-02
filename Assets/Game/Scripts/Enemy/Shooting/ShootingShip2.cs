using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingShip2 : MonoBehaviour
{
    public GameObject bulletPrefab;  // Prefab de la bala
    public Transform firePoint;  // Punto desde donde se disparan las balas
    public float fireRate = 3f;  // Frecuencia de disparo

    private float nextFireTime = 0f;

    public float bulletForce = 2f;

    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    void Shoot()
    {
        GameObject nuevaBala = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = nuevaBala.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.forward * -bulletForce, ForceMode2D.Impulse);
    }
}
