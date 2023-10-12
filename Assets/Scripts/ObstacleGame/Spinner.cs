using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotatationSpeed = 30f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpinnerRotation();
    }

    void SpinnerRotation()
    {
        float yRotation = rotatationSpeed * Time.deltaTime;
        transform.Rotate(0, yRotation, 0);
    }
}
