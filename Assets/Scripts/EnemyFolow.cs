using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFolow : MonoBehaviour
{
    private Rigidbody enemyBall;
    private GameObject player;

    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        enemyBall = GetComponent<Rigidbody>();
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 objetiveFind = (player.transform.position - transform.position).normalized;
        enemyBall.AddForce( objetiveFind * speed);
    }
}
