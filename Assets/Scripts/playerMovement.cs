using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody playerRB;
    private GameObject FocusPoint;

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
        fowardInput = Input.GetAxis("Vertical");
        playerRB.AddForce(FocusPoint.transform.forward * fowardInput * movementSpeed);
    }
}
