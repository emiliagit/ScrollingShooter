using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab de la bala
    public Transform firePoint; // Punto desde donde se disparará la bala
    public float bulletSpeed = 5f; // Velocidad de la bala
    public float fireRate = 1f; // Tiempo entre disparos
    private float nextFireTime = 0f;


    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // Asigna el jugador con la etiqueta "Player"
    }

    void Update()
    {
        if (Time.time > nextFireTime)
        {
            nextFireTime = Time.time + fireRate;
            Shoot();
        }
       
    }

    void Shoot()
    {
        if (player != null)
        {
            Vector2 direction = (player.position - firePoint.position).normalized; // Dirección hacia el jugador
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed; // Asigna la velocidad a la bala
        }
    }

}
