using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delaydeath : MonoBehaviour
{
    public float dieAfterTime = 10.0f;
    float timer = 0.0f;


    // Update is called once per frame
    void Update()
    {
        // every second it will add one to the timer 
        timer += Time.deltaTime;

        if(timer > dieAfterTime)
        {
            Destroy(gameObject);
        }
    }
}
