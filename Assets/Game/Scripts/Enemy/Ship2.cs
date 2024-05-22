using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship2 : EnemyPadre
{
    public float speed = 5f; // Velocidad de movimiento del enemigo
    public float zigzagWidth = 3f; // Anchura del zigzag
    public float forwardSpeed = 2f; // Velocidad de avance hacia adelante

    private bool movingRight = true;
    private float zigzagTimer = 0f;
    public float zigzagDuration = 1f; // Duración del movimiento en una dirección (izquierda o derecha)


    private void Start()
    {
        hp = 6;
    }
    void Update()
    {
        MoveInZigZag();
    }

    void MoveInZigZag()
    {
        // Calcula la posición en zigzag
        Vector2 newPos = transform.position;
        if (movingRight)
        {
            newPos.y += speed * Time.deltaTime;
        }
        else
        {
            newPos.y -= speed * Time.deltaTime;
        }

        // Avanza hacia adelante
        newPos.x -= forwardSpeed * Time.deltaTime;

        // Actualiza la posición del enemigo
        transform.position = newPos;

        // Actualiza el temporizador y cambia de dirección si es necesario
        zigzagTimer += Time.deltaTime;
        if (zigzagTimer >= zigzagDuration)
        {
            movingRight = !movingRight;
            zigzagTimer = 0f;
        }
    }
}

