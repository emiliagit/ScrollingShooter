using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingShip1 : MonoBehaviour
{
  
    public GameObject projectilePrefab;

    public Transform firePoint; 

    public int projectilesPerWave = 5; 
    public float timeBetweenWaves = 5f; 
    public float timeBetweenProjectiles = 0.5f;

    public float bulletForce = 2f;

    private void Start()
    {
        // Start the shooting coroutine
        StartCoroutine(ShootWaves());
    }

    private IEnumerator ShootWaves()
    {
        while (true) // Loop indefinitely
        {
            yield return StartCoroutine(ShootWave());
            yield return new WaitForSeconds(timeBetweenWaves);
        }
    }

    private IEnumerator ShootWave()
    {
        for (int i = 0; i < projectilesPerWave; i++)
        {
            ShootProjectile();
            yield return new WaitForSeconds(timeBetweenProjectiles);
        }
    }

    private void ShootProjectile()
    {
        GameObject nuevaBala = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = nuevaBala.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.forward * -bulletForce, ForceMode2D.Impulse);
    }
}
