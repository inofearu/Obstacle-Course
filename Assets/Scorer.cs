using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int collisionCount = 0;
    private void OnCollisionEnter(Collision other) {
        collisionCount ++;
        Debug.Log("You have bumped into an object " + collisionCount + " number of times");
        
    }
}