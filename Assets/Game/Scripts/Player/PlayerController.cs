using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;
    private Rigidbody2D rb;

    public float minX = -10f;
    public float maxX = 10f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontalMovement, verticalMovement);

        Vector2 newPosition = rb.position + movement * movementSpeed * Time.deltaTime;
        //rb.velocity = movement * movementSpeed;


        // Verificar los límites en el eje X
        if (newPosition.x < minX)
        {
            newPosition.x = minX;
        }
        else if (newPosition.x > maxX)
        {
            newPosition.x = maxX;
        }

        rb.MovePosition(newPosition);

       

    }

  




}
