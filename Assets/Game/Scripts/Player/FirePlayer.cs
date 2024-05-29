using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlayer : MonoBehaviour
{
    //public GameObject firePrefab;

    //public float speed = 10f; // Velocidad del proyectil, se puede modificar desde el Inspector
    //public Vector3 direction = Vector3.down;

    private void Start()
    {
        Destroy(gameObject, 10f);
    }

    private void Update()
    {
        //transform.Translate(direction.normalized * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.TryGetComponent(out EnemyPadre enemy))
        {
            enemy.RecibirDanio();
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            //GameObject fire = Instantiate(firePrefab, transform.position, Quaternion.identity);
            //Destroy(fire, 1f);
            Debug.Log("Colision");
            Destroy(gameObject);
        }
    }
}
