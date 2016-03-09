using UnityEngine;
using System.Collections;

public class IFStatement : MonoBehaviour
{
    public float hotchocolateTemperature = 50.0f;
    public float hotLimitTemperature = 35.0f;
    public float coldLimitTemperature = 25.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        hotchocolateTemperature -= Time.deltaTime * 5f;

    }

    void TemperatureTest()
    {
        // If the coffee's temperature is greater than the hottest drinking temp..
        if (hotchocolateTemperature > hotLimitTemperature)
        {
            print("Hot Chocolate is too hot.");
        }

        //If it isn't, but the coffee temp is less than coldest drinking temp...
        else if (hotchocolateTemperature < coldLimitTemperature)
        {
            print("Hot Chocolate is too cold.");
        }

        //If it is neither of those then...
        else {
            print("Hot Chocolate is just right.");
        }

    }
}
