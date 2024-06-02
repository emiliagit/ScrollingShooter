using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : Shoot
{
    public float FireRate = 3f;

    private float NextFireTime = 0f;

    private void Update()
    {
        if (Time.time >= NextFireTime)
        {
            ShootProjectile();
            NextFireTime = Time.time + 1f / FireRate;
        }

    }

}
