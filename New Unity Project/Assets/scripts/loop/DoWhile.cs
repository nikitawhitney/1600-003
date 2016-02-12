using UnityEngine;
using System.Collections;

public class DoWhile : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        bool shouldContinue = false;

        do
        {
            print("I need a nap");
        } while (shouldContinue == true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
