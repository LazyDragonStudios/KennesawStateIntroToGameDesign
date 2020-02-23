using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public float x1;
    public float y1;
    public float z1;

    public float x2;
    public float y2;
    public float z2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            player1.GetComponent<Transform>().position = new Vector3(x1,y1,z1);
        }

        if (other.gameObject.tag.Equals("Player2"))
        {
            player2.GetComponent<Transform>().position = new Vector3(x2,y2,z2);
        }
    }
}
