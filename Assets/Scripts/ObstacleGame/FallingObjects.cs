using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjects : MonoBehaviour
{
    float timeBeforeFalling = 1f;
    MeshRenderer obstacleRenderer;
    Rigidbody rBody; 
    void Start()
    {
        obstacleRenderer = GetComponent<MeshRenderer>();
        rBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Time.time > timeBeforeFalling)
        {
            obstacleRenderer.enabled = true;
            rBody.useGravity = true;
        }
    }
}
