using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPadre : MonoBehaviour
{
    public float hp;

   
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
        hp -= 1;
       
    }

    //collision.gameObject.GetComponent<LifePlayer>().TakeDamage(1);
}
