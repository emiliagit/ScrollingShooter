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
        // Instantiate the projectile at the firePoint's position and rotation
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }
}
