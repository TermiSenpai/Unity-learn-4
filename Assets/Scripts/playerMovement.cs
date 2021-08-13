using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody playerRB;
    private GameObject FocusPoint;
    public GameObject powerUpActiveObject;
    public GameObject gameOverUI;

    public bool gameOver = false;
    private float rotationSpeed = 1.0f;
    public bool powerUpActive = false;
    public float movementSpeed = 4f;
    float fowardInput;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        FocusPoint = GameObject.Find("focusPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            //get user input
            fowardInput = Input.GetAxis("Vertical");
            // add force to move the player
            playerRB.AddForce(FocusPoint.transform.forward * fowardInput * movementSpeed);
            // power up indicator following the player
            powerUpActiveObject.transform.position = transform.position;
            powerUpActiveObject.transform.Rotate(Vector3.up * rotationSpeed);
        }

        if(transform.position.y <= -10)
        {
            Destroy(gameObject);
            Destroy(powerUpActiveObject);
            gameOver = true;
            gameOverUI.gameObject.SetActive(true);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("powerUP"))
        {
            // powerUp activation
            Destroy(other.gameObject);
            powerUpActiveObject.gameObject.SetActive(true);
            powerUpActive = true;
            StartCoroutine(PowerUpTemporizator());
        }
    }

    IEnumerator PowerUpTemporizator()
    {
        // power up temporizator
        yield return new WaitForSeconds(10);
        powerUpActive = false;
        powerUpActiveObject.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy") && powerUpActive)
        {
            // player to enemy colision
            Rigidbody enemyRB = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 enemyThrow = (collision.gameObject.transform.position - transform.position);

            enemyRB.AddForce(enemyThrow * 5, ForceMode.Impulse);
            // Debug.Log($"El jugador colisionó contra {collision.gameObject} con powerup {powerUpActive}");
        }
    }
}
