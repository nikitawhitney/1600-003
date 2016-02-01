using UnityEngine;
using System.Collections;

public class IFstatement : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        float coffeeTemperature = 85.0f;
        float hotLimitTemperature = 70.0f;
        float coldLimitTemperature = 40.0f;


        
        // Update is called once per frame
        void Update ()
    {
            if (Input.GetKeyDown(KeyCode.Space))
                TemperatureTest();

            coffeeTemperature -= Time.deltaTime * 5f;

    }

        void TemperatureTest ()
        // if the coffee's temperature is greater than the hottest drinking temperature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            print("Coffee is too hot.");
        }

        // if it isn't , but the coffee temperature is less than the coldest drinking temperature...
        else if (coffeeTemperature < coldLimitTemperature)
        {
            print("Coffee is too cold.");
        }

        //if it is neither of those then..
        else { print("Coffee is just right."); }
     }
    }

