using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaRising : MonoBehaviour {

    public float riseSpeed = 0.0f, endY = 0.0f;

    void Start() {
        endY = this.transform.position.y + endY;
    }

	// Update is called once per frame
	void Update () {

        if (this.transform.position.y < endY) 
        {
            this.transform.Translate(new Vector3(0, riseSpeed * Time.deltaTime, 0));
        }
    }
}
