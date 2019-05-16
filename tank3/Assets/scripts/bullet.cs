using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float thrust = 150.0f;
    // Start is called before the first frame update
    void Start()
    {
        // using physics, one time, add an instant force impulse to the rigidbody 
        GetComponent<Rigidbody>().AddForce(transform.forward * thrust, ForceMode.Impulse );
    }


}
