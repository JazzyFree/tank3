using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyBullet : MonoBehaviour
{
    public GameObject Projectile;
    public float delay = 1.0f;

    public GameObject enemyParent;
    public Attack AttackScript;
    // Start is called before the first frame update
    void Start()
    {// this make sure that it get the script from its own parent object.
        enemyParent = gameObject.transform.root.gameObject;
        AttackScript = enemyParent.GetComponentInChildren<Attack>();
    }

    // Update is called once per frame
    void Update()
    {
        //make sure that the float value is either zero point zero allthe way one point
        delay = Mathf.Clamp01(delay);
        //removes one second
        if(delay > 0.0f)
        {
            delay -= Time.deltaTime;
        }
        if(delay < 0.01f)
        {
            delay = 1.0f;
        }
        // if both are true we are going to instantiate 
        if (AttackScript.attack && delay == 1.0f)
        {
            Instantiate(Projectile, transform.position, transform.rotation);
        }
    }
}
