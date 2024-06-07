using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship1 : EnemyPadre
{
    public float ScrollSpeed = 8.0f;
   

    void Start()
    {
        currentHealth = 50;

    }

    void Update()
    {
        ShipMovement();

        if (currentHealth <= 0)
        {
            Die();
        }

    }

    public void ShipMovement()
    {
            
        transform.Translate(Vector3.right * ScrollSpeed * Time.deltaTime);

    }
}
