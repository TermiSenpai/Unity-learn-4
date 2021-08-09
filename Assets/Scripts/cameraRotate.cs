using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotate : MonoBehaviour
{
    private float horizontalMove;
    public float rotationSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        horizontalMove += rotationSpeed * Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0.0f, horizontalMove, 0.0f);
    }
}
