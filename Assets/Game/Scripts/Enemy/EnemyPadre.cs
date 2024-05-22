using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPadre : MonoBehaviour
{
    protected float hp;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RecibirDanio()
    {
        hp -= 10;
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Colision con player");
            //collision.gameObject.GetComponent<LifePlayer>().TakeDamage(1);
        }
    }
}
