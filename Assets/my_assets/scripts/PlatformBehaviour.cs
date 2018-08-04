using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour : MonoBehaviour {

    public float Speed = 1.0f, start, end;//frames/second
    private Rigidbody rb;
    public bool run = false;

    // Use this for initialization
    void Start () {
        start = 0;
        end = 180;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        if (run)
        {
            Oscillate();
        }
    }

    public void RunAnimation() {
        run = !run;
    }
    void Oscillate() {
        if (start <= end)
        {
            start += Time.deltaTime;
            this.transform.Translate(new Vector3(0, Speed * Time.deltaTime, 0));
        }
        else {
            start = 0;
            Speed *= -1;
        }
    }
    void OnTriggerStay(Collider other)
    {

        if (other.tag == "player")
        {
            other.transform.parent = transform;
            //transform.parent = other.transform;

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "player")
        {
            other.transform.parent = null;
            //transform.parent = null;

        }
    }
}
