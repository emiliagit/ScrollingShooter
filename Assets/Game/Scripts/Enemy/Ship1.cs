using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship1 : EnemyPadre
{
    public float ScrollSpeed = 8.0f;
   

    void Start()
    {
        hp = 3;

    }

    void Update()
    {
        ShipMovement();


        
        //RecibirDanio();

        if (hp <= 0)
        { 
            //ahip1animator.SetBool("enemyDeath", true);


            Destroy(gameObject, 1f);
        }
    }

    public void ShipMovement()
    {
        if (hp > 0)
        {
            
            transform.Translate(Vector3.right * ScrollSpeed * Time.deltaTime);

        }

    }
}
