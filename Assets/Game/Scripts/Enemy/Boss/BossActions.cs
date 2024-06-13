using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossActions : MonoBehaviour
{
    public string enemyTag = "Enemy"; 
    public Vector3 targetPosition; 
    public float moveSpeed = 5f; 
    public float attackDelay = 2f;

    //private bool isMoving = false;
    private bool hasArrived = false;
    private float attackTimer = 0f;

    private BossAttack boss;

    void Start()
    {

        boss.GetComponent<Shoot>().enabled = false;
        // Desactivar el boss al inicio
        //gameObject.SetActive(false);
    }

    void Update()
    {
        // Contar la cantidad de objetos con el tag "Enemy"
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        int enemyCount = enemies.Length;

        // Si no hay enemigos, activar el boss y moverlo a la posición objetivo
        if (enemyCount == 0 && !hasArrived)
        {
            //gameObject.SetActive(true);
            MoveToTarget();
        }

        // Si ha llegado a la posición objetivo, comenzar el ataque después del delay
        if (hasArrived)
        {
            attackTimer += Time.deltaTime;
            if (attackTimer >= attackDelay)
            {
                boss.GetComponent<Shoot>().enabled = true;
            }
        }
    }

    void MoveToTarget()
    {
      
        float step = moveSpeed * Time.deltaTime; // Calcular el paso de movimiento según la velocidad y el tiempo
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

        //// Verificar si ha llegado a la posición objetivo
        //if (Vector3.Distance(transform.position, targetPosition) < 0.001f)
        //{
        //    hasArrived = true;
        //    isMoving = false;
        //}
    }
}
