using UnityEngine;
using System.Collections;

public class Datatype : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Vector3 pos = transform.position;
        pos = new Vector3(0, 4, 0);

        Transform tran = transform;
        tran.position = new Vector3(0, 4, 0);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
