using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    float front;
    public float movementSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        front += movementSpeed * Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * front);

    }
}
