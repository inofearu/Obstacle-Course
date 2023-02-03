using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int collisionCount = 0;
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Hit") is false && other.gameObject.CompareTag("doNotCount") is false)
        {
            collisionCount ++;
            Debug.Log("You have bumped into an object " + collisionCount + " number of times");
        }

        
    }
}
