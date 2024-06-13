using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : EnemyPadre
{
    public GameObject bulletPrefab;
    public Transform firePoint;

    public float bulletSpeed = 5f;

    public float fireRate = 1f;
    private float nextFireTime = 0f;

    bool fireEffectSpawned = false;

    public string enemyTag = "Enemy";
    public Vector3 targetPosition;
    public float moveSpeed = 5f;
    public float attackDelay = 2f;

  
    private bool hasArrived = false;
   

    private Transform player;

    void Start()
    {
        currentHealth = 100;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        
       

    }

    private void FixedUpdate()
    {
        if (currentHealth <= 50 && !fireEffectSpawned)
        {
            DamageBoss();
            fireEffectSpawned = true;
        }

        if (currentHealth <= 0)
        {
            Die();
            Destroy(FireEfect1);
            Destroy(FireEfect2);
            Debug.Log("smoke desactivado");
        }

        // Contar la cantidad de objetos con el tag "Enemy"
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        int enemyCount = enemies.Length;


        if (enemyCount == 0 && !hasArrived)
        {
            MoveToTarget();
            Debug.Log("moviendo boss");
        }

        if (hasArrived && Time.time > nextFireTime)
        {
            Debug.Log("boss llego. ataque activado");
            nextFireTime = Time.time + fireRate;
            Shoot();
        }

    }

    public void Shoot()
    {
        Vector2 direction = (player.position - firePoint.position).normalized;
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
        Destroy(bullet, 3f);

    }

    void MoveToTarget()
    {
        //isMoving = true;
        float step = moveSpeed * Time.deltaTime; // Calcular el paso de movimiento según la velocidad y el tiempo
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

        // Verificar si ha llegado a la posición objetivo
        if (Vector3.Distance(transform.position, targetPosition) < 0.001f)
        {
            hasArrived = true;
           
        }
    }

}
