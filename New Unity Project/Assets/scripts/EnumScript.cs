using UnityEngine;
using System.Collections;

public class EnumScript : MonoBehaviour
{   
    enum Direction { Up, Down, Left, Right};

	// Use this for initialization
	void Start ()
    {
        Direction myDirection;

        myDirection = Direction.Up;
	
	}
	
    Direction ReverseDirection (Direction dir)
    {
        if (dir == Direction.Up)
            dir = Direction.Down;
        else if (dir == Direction.Down)
            dir = Direction.Up;
        else if (dir == Direction.Left)
            dir = Direction.Right;
        else if (dir == Direction.Right)
            dir = Direction.Left;

        return dir;
    }
	// Update is called once per frame
	void Update () {
	
	}
}
