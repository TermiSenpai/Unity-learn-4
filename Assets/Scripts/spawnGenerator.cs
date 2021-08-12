using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    private Vector3 position;
    public GameObject powerUp;

    private const float spawnVectorY = -1.80f;
    private float spawnVectorX;
    private float spawnVectorZ;
    private float maxRandomPosition = 10f;

    // Start is called before the first frame update
    void Start()
    {
        // enemy spawn
        position = vectorSpawnGenerator();
        Instantiate(enemyPrefab, position, enemyPrefab.transform.rotation);

        //powerUp Spawn
        position = vectorSpawnGenerator();
        Instantiate(powerUp, position, powerUp.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float randomPositionGeneration(float min, float max)
    {
        return Random.Range(min, max);
    }

    public Vector3 vectorSpawnGenerator()
    {
        //random position
        spawnVectorX = randomPositionGeneration(-maxRandomPosition, maxRandomPosition);
        spawnVectorZ = randomPositionGeneration(-maxRandomPosition, maxRandomPosition); 

        return new Vector3(spawnVectorX, spawnVectorY, spawnVectorZ);
    }
}
