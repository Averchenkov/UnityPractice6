﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script4 : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log(name);
        Debug.Log(transform.position);
        Debug.Log(GetComponent<Renderer>().material.color);
        Debug.Log(GetComponent<Rigidbody>().mass);
    }
}
