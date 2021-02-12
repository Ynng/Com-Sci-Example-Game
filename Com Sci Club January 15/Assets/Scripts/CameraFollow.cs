﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset = new Vector3(0, 3.5f, -7);

    // Update is called once per frame
    void Update()
    {
        FindObjectOfType<Camera>().transform.position = playerTransform.position + offset;
        //Debug.Log(playerTransform.position);
    }
}
