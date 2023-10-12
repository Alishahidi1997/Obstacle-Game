using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
  
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xPos = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zPos = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xPos, 0, zPos);
    }
}
