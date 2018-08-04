using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour {
    public GameObject checkpoint;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="player")
        {
          PlayerController x=  other.GetComponent<PlayerController>();
            x.lastCheckpoint = transform.position;
        }
    }
        
}
