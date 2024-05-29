using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShip1 : MonoBehaviour
{
    public GameObject firePrefab;

    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.TryGetComponent(out LifePlayer player))
        {
            player.RecibirDanio(10);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject fire = Instantiate(firePrefab, transform.position, Quaternion.identity);
            Destroy(fire, 1f);
            Debug.Log("Colision");
            Destroy(gameObject);
        }
    }
}
