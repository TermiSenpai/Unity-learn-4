using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    private Vector3 position;

    private const float spawnVectorY = -1.50f;
    private float spawnVectorX;
    private float spawnVectorZ;
    private float maxRandomPosition = 10f;

    // Start is called before the first frame update
    void Start()
    {
        spawnVectorX = randomPositionGeneration(-maxRandomPosition, maxRandomPosition);
        spawnVectorZ = randomPositionGeneration(-maxRandomPosition, maxRandomPosition);
        position = new Vector3(spawnVectorX, spawnVectorY, spawnVectorZ);

        Instantiate(enemyPrefab, position, enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float randomPositionGeneration(float min, float max)
    {
        return Random.Range(min, max);
    }
}
