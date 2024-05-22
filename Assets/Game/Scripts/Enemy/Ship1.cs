using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship1 : EnemyPadre
{
    public float velocidadMovimiento = 1.5f;
    public float distanciaMovimiento = 4f;

    private Vector3 posicionInicial;
    //public Animator ahip1animator;

    
    void Start()
    {
        hp = 3;

        posicionInicial = transform.position;
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
            // Calcula la posición a la que el fantasma debe moverse
            Vector3 posicionDestino = posicionInicial + Vector3.up * distanciaMovimiento * Mathf.Sin(Time.time * velocidadMovimiento);

            // Mueve al fantasma hacia la posición destino
            transform.position = Vector3.Lerp(transform.position, posicionDestino, Time.deltaTime);

        }

    }
}
