using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlayer : MonoBehaviour
{
    public GameObject firePrefab;

    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    //if (collision.gameObject.TryGetComponent(out EnemyLife enemy))
    //    //{
    //    //    enemy.TakeDaño(20);
    //    //}
    //    
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameObject fire = Instantiate(firePrefab, transform.position, Quaternion.identity);
            Destroy(fire, 1f);
            Debug.Log("Colision");
            Destroy(gameObject);
        }
    }

}
