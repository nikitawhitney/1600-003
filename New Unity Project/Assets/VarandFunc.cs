using UnityEngine;
using System.Collections;

public class VarandFunc : MonoBehaviour
{
    int myInt = 50;
    // Use this for initialization
    void Start() {

        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }
    int MultiplyByTwo (int number)
    { 
        int ret;
        ret = number * 2;
        return ret;
    }

	// Update is called once per frame
	void Update () {
	
	}
}
