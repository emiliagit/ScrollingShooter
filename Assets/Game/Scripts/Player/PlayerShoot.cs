using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : Shoot
{
    private float tiempoUltimoDisparo;

    [SerializeField] private float cadenciaDisparo = 0.3F;


    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time - tiempoUltimoDisparo > cadenciaDisparo)
        {
            ShootProjectile();
        }
    }


    protected override void ShootProjectile()
    {
        tiempoUltimoDisparo = Time.time;
       base.ShootProjectile();

    }

   
}
