using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour
    {
    int chipsInTheBag = 5;

	// Use this for initialization
	void Start ()
    {
        while(chipsInTheBag > 0)
        {
            Debug.Log("I ate a chip");
                chipsInTheBag--;
        }	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
