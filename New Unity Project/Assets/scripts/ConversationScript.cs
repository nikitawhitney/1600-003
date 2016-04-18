using UnityEngine;
using System.Collections;

public class ConversationScript : MonoBehaviour
{

    public int intelligence = 4;

        void Greet ()
    {
        switch (intelligence)
        {
            case 4:
                print("What a well behaved and lovely dog you have!");
                break;
            case 3:
                print("Wow! What a cute dog! ");
                break;
            case 2:
                print("OMG a dog!");
                break;
            case 1:
                print("!!!!!! DOG!! so smol and fluf!!");
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }
    }
	
}
