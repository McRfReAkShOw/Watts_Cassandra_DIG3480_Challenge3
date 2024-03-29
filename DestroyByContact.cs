﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_By_Contact : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
