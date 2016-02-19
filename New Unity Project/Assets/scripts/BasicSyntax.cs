using UnityEngine;
using System.Collections;

public class BasicSyntax : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Debug.Log(transform.position.x);
        if(transform.position.y <= 7f)
        {
            Debug.Log("I'm going to die!");
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
