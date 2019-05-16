using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public float rotationSpeed = 90.0f;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        // move and rotate the tank 
        float rotateTank = Input.GetAxis("Horizontal");
        float moveTank = Input.GetAxis("Vertical");

        // control the speed of the tank 
        GetComponent<Rigidbody>().velocity = transform.forward * moveSpeed * moveTank;

        transform.Rotate(Vector3.up * rotationSpeed * rotateTank * Time.deltaTime);

    }
}
