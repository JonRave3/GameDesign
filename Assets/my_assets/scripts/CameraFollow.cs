using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Camera pCamera;
	// Use this for initialization
	void Start ()
    {
		pCamera= GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        pCamera.transform.LookAt(GameObject.Find("playerFocus").GetComponent<BoxCollider>().transform);
	}
}
