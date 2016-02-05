using UnityEngine;
using System.Collections;

public class IFStatement : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
        	
	}

    void TemperatureTest()
    {
        // If the coffee's temperature is greater than the hottest drinking temp..
        if(coffeeTemperature > hotLimitTemperature)
        {
            print("Coffee is too hot.");
        }

        //If it isn't, but the coffee temp is less than coldest drinking temp...
        else if(coffeeTemperature < coldLimitTemperature)
        {
            print("Coffee is too cold.");
        }

        //If it is neither of those then...
        else { print("Coffee is just right.");
        }

    }
}
