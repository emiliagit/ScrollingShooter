using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class FireEnemy : MonoBehaviour
{
    public GameObject firePrefab;

    private void Start()
    {

    }

    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Colision con player");
            GameObject fire = Instantiate(firePrefab, transform.position, Quaternion.identity);
            Destroy(fire, 1f);
            Destroy(gameObject);
        }
        if (collision.gameObject.TryGetComponent(out LifePlayer player))
        {
            player.RecibirDanio(10);
            Debug.Log("vida restada");
        }
        if (collision.gameObject.CompareTag("FirePlayer"))
        {
            Destroy(gameObject);
        }

    }

    
}
