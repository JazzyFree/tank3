using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    public GameObject Projectile;

    // Update is called once per frame
    void Update()
    {
        // write a if statement that is going to look for pressing a button 
        if (Input.GetButtonDown("Jump") || Input.GetButtonDown("Fire1"))
        {
            Instantiate(Projectile, transform.position, transform.rotation);
        }
    }
}
