using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnGenerator : MonoBehaviour
{
    private playerMovement playerMovementScript;
    public GameObject enemyPrefab;
    private Vector3 position;
    public GameObject powerUp;

    private int enemyGeneration = 1;
    private int enemyInPlatform;
    private const float spawnVectorY = -1.80f;
    private float spawnVectorX;
    private float spawnVectorZ;
    private float maxRandomPosition = 10f;

    // Start is called before the first frame update
    void Start()
    {
        playerMovementScript = GameObject.Find("player").GetComponent<playerMovement>();
        enemyGenerator(enemyGeneration);
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerMovementScript.gameOver)
        { 
            enemyInPlatform = FindObjectsOfType<EnemyFolow>().Length;

            if (enemyInPlatform == 0)
            {
                enemyGenerator(enemyGeneration++);
            }
        }
    }

    void enemyGenerator(int enemyToGenerate)
    {
        for (int i = 0; i < enemyToGenerate; i++)
        {
            // enemy spawn
            position = vectorSpawnGenerator();
            Instantiate(enemyPrefab, position, enemyPrefab.transform.rotation);

            //powerUp Spawn
            position = vectorSpawnGenerator();
            Instantiate(powerUp, position, powerUp.transform.rotation);
        }
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
