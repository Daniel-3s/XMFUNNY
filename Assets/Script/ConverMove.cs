using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConverMove : MonoBehaviour {
    public float speed;
    public Transform start;
    public Transform end;
    public Vector3 s;
    public Vector3 e;
    public bool go;
    public bool back;
	// Use this for initialization
	void Start () {
        s = start.position;
        e = end.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(start.position.y == s.y)
        {
            go = true;
            back = false;
        }
        if(start.position.y == e.y)
        {
            back = true;
            go = false;
        }
        if (go == true)
        {
            transform.position = Vector3.MoveTowards(start.position, e, speed * Time.deltaTime);
        }
        if (back == true)
        {
            transform.position = Vector3.MoveTowards(start.position, s, speed * Time.deltaTime);
        }
	}
}
