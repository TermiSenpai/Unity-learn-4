using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFolow : MonoBehaviour
{
    private Rigidbody enemyBall;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyBall = GetComponent<Rigidbody>();
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        enemyBall.AddForce(player.transform.position - transform.position);
    }
}
