﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover_Script : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
