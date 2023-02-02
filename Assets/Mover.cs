using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Player Move Speed
    [SerializeField] float moveSpeed = 15f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate() 
    {
        float xValue = Input.GetAxisRaw("Horizontal");
        float zValue = Input.GetAxisRaw("Vertical"); // correlates to forward move
        rb.velocity = new Vector3(Input.GetAxisRaw ("Horizontal"),0 , Input.GetAxisRaw ("Vertical")).normalized * moveSpeed;
    }
}