using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemigos : MonoBehaviour
{
    
    public float spawnInterval = 1f; 

    //listas para posicion de enemigos;
    public GameObject[] enemyPrefab;
    public Vector3[] spawnPosition;

    //cantidad de enemigos en mapa
    public int maxEnemyCount = 8;
    public int currentEnemyCount = 0;
    

    bool spawnerActive = true;
    public float delay = 10f; 

    private void Start()
    {
        
        spawnerActive = true;
        StartCoroutine(timer());
    }

    private IEnumerator timer()
    {
        while (spawnerActive)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(delay);
        }
    }

    private void Update()
    {
        if (currentEnemyCount >= maxEnemyCount)
        {
            spawnerActive = false;
            //Debug.Log("se desactivo spawner");
        }
        if (currentEnemyCount < maxEnemyCount)
        {
            spawnerActive = true;
            //Debug.Log("se activo spawner");
        }
    }

    void SpawnEnemy()
    {
        if (currentEnemyCount < maxEnemyCount)
        {
            currentEnemyCount++;

            int randomIndex = Random.Range(0, enemyPrefab.Length);
            int randomPosition = Random.Range(0, spawnPosition.Length);

            GameObject randomEnemy = enemyPrefab[randomIndex];

            Instantiate(randomEnemy, spawnPosition[randomPosition], randomEnemy.transform.rotation);

        }
    }
}
