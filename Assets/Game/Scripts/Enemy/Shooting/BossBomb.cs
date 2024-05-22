using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBomb : MonoBehaviour
{


    public GameObject bombPrefab; // Prefab de la bomba
    public Transform bombPoint1;
    public Transform bombPoint2;
    public float bombSpeed = 3f; // Velocidad de la bomba
    public float bombRate = 5f; // Tiempo entre lanzamiento de bombas
    private float nextBombTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextBombTime)
        {
            nextBombTime = Time.time + bombRate;
            DropBomb();
        }
    }

    void DropBomb()
    {    
        GameObject bomb = Instantiate(bombPrefab, bombPoint1.position, bombPoint1.rotation);
        GameObject bomb2 = Instantiate(bombPrefab, bombPoint2.position, bombPoint2.rotation);

    }
}
