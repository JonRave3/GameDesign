using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour : MonoBehaviour {

    public float Speed = 1.0f, start, end;//frames/second
    public bool run;

    // Use this for initialization
    void Start () {
        start = 0;
        end = 4;
        run = false;
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

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "player")
        {
            other.transform.parent = null;
            //transform.parent = null;
        }
    }
}
