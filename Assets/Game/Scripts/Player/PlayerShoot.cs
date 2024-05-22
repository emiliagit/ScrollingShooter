using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 10f;

    private float tiempoUltimoDisparo;
    [SerializeField] private float cadenciaDisparo = 0.3F;

  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time - tiempoUltimoDisparo > cadenciaDisparo)
        {
            Disparar();
        }
    }

    private void Disparar()
    {
        tiempoUltimoDisparo = Time.time;
        GameObject nuevaBala = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = nuevaBala.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(nuevaBala, 1f);

    }

   
}
