using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float dropTime = 5f;
    MeshRenderer rend;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        rend.enabled = false;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
       if(Time.time > dropTime)
       {
        rend.enabled = true;
        rb.useGravity = true;
       }
    }
}
