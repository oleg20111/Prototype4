using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ememyPrefab;
    public GameObject puwerupPrefab;
    private float spawnRange = 9;
    public int enemyCount;
    private int waveNumber = 1;

    private void Start()
    {
        Instantiate(puwerupPrefab, GenerateSpawnPosistion(), ememyPrefab.transform.rotation);
        SpawnEnemyWave(waveNumber);        
    }

    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        for(int i=0; i<enemiesToSpawn; i++)
        {
            Instantiate(ememyPrefab, GenerateSpawnPosistion(), ememyPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosistion()
    {
        float spawnPozX = Random.Range(-spawnRange, spawnRange);
        float spawnPozZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPoz = new Vector3(spawnPozX, 0, spawnPozZ);
        return randomPoz;
    }

    private void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if(enemyCount == 0) 
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Instantiate(puwerupPrefab, GenerateSpawnPosistion(), ememyPrefab.transform.rotation);
        }
    }
}
