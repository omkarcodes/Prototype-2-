using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    float spawnRangeX = 10f;
    float spawnPosZ = 20f;
    float delayStart = 2f;
    float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalX", delayStart, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimalX()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosX = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        
        Instantiate(animalPrefabs[animalIndex], spawnPosX, animalPrefabs[animalIndex].transform.rotation);
        
    }
   

}
