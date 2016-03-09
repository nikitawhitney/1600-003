using UnityEngine;
using System.Collections;

public class ScopeAndAccess : MonoBehaviour
{
    public int alpha = 7;

    private int beta = 0;
    private int gamma = 7;

    private AnotherClass myOtherClass;

	// Use this for initialization
	void Start ()
    {
        alpha = 23;

        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.kiwi);
	
	}

    void Example (int pens, int paint)
    {
        int answer;
        answer = pens * paint * alpha;
        Debug.Log(answer);
    }
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log("Alpha is set to:" + alpha);
	
	}
}
