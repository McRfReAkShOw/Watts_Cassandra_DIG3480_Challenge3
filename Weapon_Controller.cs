﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Controller : MonoBehaviour
{
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", delay, fireRate);
    }

    void Fire()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        GetComponent<AudioSource>().Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
