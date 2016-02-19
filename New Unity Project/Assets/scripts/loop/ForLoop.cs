using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour
{
    int numDogs = 4;

	// Use this for initialization
	void Start ()
    {
        for (int i = 0; i < numDogs; i++)
        {
            Debug.Log("Creating dog number: " + i);
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
