using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public int health = 1;

    // Update is called once per frame
    void Update()
    {
       
        if (health < 1 )
        {
            Destroy(gameObject.transform.root.gameObject);
        }
    }

 void OnCollisionEnter(Collision other)
    {// if it detect that the projectile enters the collision 
        if (other.gameObject.CompareTag("Bullet"))
        {
            health--;
        }
    }
}
