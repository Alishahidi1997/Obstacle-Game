using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    Color initialColor;
    const string PLAYER = "Player";
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        initialColor = GetComponent<MeshRenderer>().material.color;
        if (collision.gameObject.tag.Equals(PLAYER))
        {
            gameObject.tag = "Hit"; 
            GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }
    /*private void OnCollisionExit(Collision collision)
    {
        
        GetComponent<MeshRenderer>().material.color = initialColor;
    }*/
}
