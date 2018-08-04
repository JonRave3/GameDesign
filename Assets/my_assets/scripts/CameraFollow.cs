using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player = null;
    public Transform target = null;
	// Use this for initialization

    void LateUpdate() {
        this.transform.LookAt(player.position);
        this.transform.position = target.position;
    }
}
