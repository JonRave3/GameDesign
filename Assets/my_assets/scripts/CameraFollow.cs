using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Camera pCamera;
    Transform focus;
    Vector3 ptr;
   public float multp;
    private float rotY;
    private float rotX = 0.0f;
    public float clampAngle = 80.0f;
    public float mouseSensitivity = 100.0f;
    // Use this for initialization
    void Start ()
    {
        rotY= 0.0f; // rotation around the up/y axis
    
		pCamera = GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {



        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = -Input.GetAxis("Mouse Y");

        rotY += mouseX * mouseSensitivity * Time.deltaTime;
        rotX += mouseY * mouseSensitivity * Time.deltaTime;

        rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

        Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
        transform.rotation = localRotation;


    }
}
