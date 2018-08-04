using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballOsc : MonoBehaviour {

    Rigidbody rb;
    public float height, move;
    bool up;
    Vector3 startPos;
    Vector3 goal;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        height = 10.0f;
      //  move = 9.8f;
        up = true;
        startPos = transform.position;
        goal = startPos;
        goal.y = startPos.y + height;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //goal.y = startPos.y + height;

        //if (up)//move up
        //{

        //    move *= 1.1f;
        //    transform.position = Vector3.MoveTowards(transform.position, goal, move * Time.deltaTime);
        //    if (transform.position == goal)
        //    {
        //        move = 0f;
        //        up = !up;
        //    }
        //}
        //else
        //{
        //    move += 2;

        //    transform.position = Vector3.MoveTowards(transform.position, startPos, move * Time.deltaTime);
        //    if (transform.position == startPos)
        //    {
        //        move = 9.8f;
        //        up = !up;
        //    }
        //}

    }
    private void FixedUpdate()
    {
        if (transform.position.y <=startPos.y)
        {
            rb.AddForce(transform.up * move);
        }

    }
}
