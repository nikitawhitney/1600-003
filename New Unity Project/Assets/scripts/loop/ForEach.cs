using UnityEngine;
using System.Collections;

public class ForEach : MonoBehaviour
{

	// Use this for initialization
	void Start () {
        string[] fish = new string[3];

        fish[0] = "First fish";
        fish[1] = "Second fish";
        fish[2] = "Third fish";

        foreach(string item in fish)
        {
            print(item);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
