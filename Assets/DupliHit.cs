using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DupliHit : MonoBehaviour
{
    Rigidbody rb;
    public GameObject Roller;
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("doNotCount") is false)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            if (gameObject.CompareTag("Hit") is false)
            {
                Instantiate(Roller);
            }
            gameObject.tag = "Hit";
        }
    }
}
