using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFolow : MonoBehaviour
{
    private playerMovement playerMovementScript;
    private Rigidbody enemyBall;
    private GameObject player;

    private float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerMovementScript = GameObject.Find("player").GetComponent<playerMovement>();
        enemyBall = GetComponent<Rigidbody>();
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerMovementScript.gameOver)
        {
        Vector3 objetiveFind = (player.transform.position - transform.position).normalized;
        enemyBall.AddForce( objetiveFind * speed);
        }
    }
}
