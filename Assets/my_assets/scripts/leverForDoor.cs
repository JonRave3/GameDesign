using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverForDoor : MonoBehaviour
{
    public GameObject lever;
    public GameObject gate;
    public List<GameObject> platforms;
    private float toggleAngle = -86.0f;
    Vector3 up;
    public float raise;
    bool open;
	// Use this for initialization
	void Start ()
    {
        
        open = false;
        up = gate.transform.position;
        up.y =up.y+ raise;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float move = 10 * Time.deltaTime;
        if (open)
        {
            gate.transform.position = Vector3.MoveTowards(gate.transform.position, up, move);
            
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag=="player")//&&!open)
        {
            lever.transform.Rotate(toggleAngle, 0, 0, Space.Self);
            toggleAngle *= -1;
            //gate.transform.position = Vector3.MoveTowards(gate.transform.position, up, move);
            open = true;
            foreach (GameObject p in platforms)
            {
                p.GetComponent<PlatformBehaviour>().RunAnimation();
            }
        }
    }
}
