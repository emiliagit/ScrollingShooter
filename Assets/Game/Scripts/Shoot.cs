using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shoot : MonoBehaviour
{

    public GameObject projectilePrefab;

    public Transform firePoint;

    public float bulletForce = 7f;

    

    protected virtual void ShootProjectile()
    { 
        GameObject nuevaBala = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = nuevaBala.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.forward * -bulletForce, ForceMode2D.Impulse);
        Destroy(nuevaBala, 3f);
    }
}
