using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemigos : MonoBehaviour
{
    //listas para posicion de enemigos;
    public GameObject[] enemyPrefab;
    public Vector3[] spawnPosition;

    bool spawnerActive = true;
    public float delay = 3f;

    public float timeToDeactivate = 5f;
    private float time;


    private void Start()
    {
        time = 0f;

        spawnerActive = true;
        StartCoroutine(timer());
       
    }

    private void Update()
    {
        time += Time.deltaTime;

        if(time > timeToDeactivate)
        {
            spawnerActive=false;
            Debug.Log("Spawner desactivado");
            enabled = false;

            
        }
    }

    private IEnumerator timer()
    {
        while (spawnerActive)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(delay);
        }
    }


    void SpawnEnemy()
    {
        if (time < timeToDeactivate)
        {
            Debug.Log("Spawner active");

            int randomIndex = Random.Range(0, enemyPrefab.Length);
            int randomPosition = Random.Range(0, spawnPosition.Length);

            GameObject randomEnemy = enemyPrefab[randomIndex];

            GameObject enemyInstance = Instantiate(randomEnemy, spawnPosition[randomPosition], randomEnemy.transform.rotation);

            Destroy(enemyInstance, 10f ) ;
        }
    }

   
}
