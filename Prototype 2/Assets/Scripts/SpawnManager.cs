using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    
    float spawnRangeX = 10f;
    float spawnPosX = -14f;
    float spawnPosZ = 20f;

    float delayStart = 2f;
    float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalX", delayStart, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", delayStart, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", delayStart, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimalX()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Quaternion Rotation = new Quaternion(0, 180, 0, 0);
        Vector3 spawnPosXX = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        
        Instantiate(animalPrefabs[animalIndex], spawnPosXX, Rotation);
       
    }
    void SpawnRandomAnimalRight()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Quaternion Rotation = new Quaternion(0,90,0,90);
        Vector3 spawnPosZZ = new Vector3(12f, 0, Random.Range(1.4f, 12f));

        Instantiate(animalPrefabs[animalIndex], spawnPosZZ, Rotation);

    }
    void SpawnRandomAnimalLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Quaternion Rotation = new Quaternion(0, -90, 0, 90);
        Vector3 spawnPosNZZ = new Vector3(12f, 0, Random.Range(1.4f, 12f));

        Instantiate(animalPrefabs[animalIndex], spawnPosNZZ, Rotation);
    }


}
