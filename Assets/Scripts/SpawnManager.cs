using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ememyPrefab;
    private float spawnRange = 9;

    private void Start()
    {
        
        Instantiate(ememyPrefab, GenerateSpawnPosistion(), ememyPrefab.transform.rotation);
    }

    private Vector3 GenerateSpawnPosistion()
    {
        float spawnPozX = Random.Range(-spawnRange, spawnRange);
        float spawnPozZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPoz = new Vector3(spawnPozX, 0, spawnPozZ);
        return randomPoz;
    }
}
