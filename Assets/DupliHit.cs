using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DupliHit : MonoBehaviour
{
    public GameObject Roller;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "doNotCount")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
            Instantiate(Roller);
        }
    }
}
