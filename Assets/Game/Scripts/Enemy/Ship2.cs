using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Ship2 : EnemyPadre
{
    public float moveSpeed = 3f; // Velocidad de movimiento hacia adelante
    public float moveDistance = 2f; // Distancia total de movimiento hacia arriba y hacia abajo
    public float rotateSpeed = 90f; // Velocidad de rotación

    private Rigidbody rb;
    private Vector3 originalPosition;
    private Quaternion originalRotation;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalPosition = transform.position;
        originalRotation = transform.rotation;
    }

    private void Update()
    {
        // Movimiento hacia adelante
        Vector3 forwardMovement = transform.right * moveSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + forwardMovement);

        //// Movimiento hacia arriba y hacia abajo
        //float newY = originalPosition.y + Mathf.Sin(Time.time) * moveDistance;
        //transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        // Rotación gradual
        Vector3 targetDirection = new Vector3(forwardMovement.x, 0f, forwardMovement.z).normalized;
        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);
    }

}

