using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Ship2 : EnemyPadre
{
    public float forwardSpeed = 5.0f; // Velocidad de movimiento hacia adelante
    public float verticalSpeed = 2.0f; // Velocidad de movimiento vertical
    public float verticalRange = 3.0f; // Rango de movimiento vertical

    private float initialY;

    void Start()
    {
       
        initialY = transform.position.y;
    }

    void Update()
    {
        // Movimiento hacia adelante
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        // Movimiento vertical
        float newY = initialY + Mathf.Sin(Time.time * verticalSpeed) * verticalRange;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

}

