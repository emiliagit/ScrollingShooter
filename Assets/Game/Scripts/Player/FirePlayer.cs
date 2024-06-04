using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FirePlayer : MonoBehaviour
{
    //public GameObject firePrefab;

    private void Start()
    {
        Destroy(gameObject, 10f);
    }

    private void Update()
    {
        
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{

    //    //if (collision.gameObject.TryGetComponent(out EnemyPadre enemy))
    //    //{
    //    //    enemy.RecibirDanio();
    //    //}

    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {

    //        //GameObject fire = Instantiate(firePrefab, transform.position, Quaternion.identity);
    //        //Destroy(fire, 1f);
    //        Debug.Log("Colision");
    //        Destroy(gameObject);
    //    }
    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
        
    //}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("colison");
        }
    }
}
