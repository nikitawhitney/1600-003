using UnityEngine;
using System.Collections;

public class BasicSyntax : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Debug.Log(transform.position.x);
        if(transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
