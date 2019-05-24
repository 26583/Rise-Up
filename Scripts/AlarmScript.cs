using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmScript : MonoBehaviour
{

    public Light lamp;
    private bool gettingBigger = true;
    // Start is called before the first frame update
    void Start()
    {
        lamp.range = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gettingBigger)
        {
            lamp.range += 4f * Time.deltaTime;
        }
        if(lamp.range >= 4)
        {
            gettingBigger = false;
        }
        if(lamp.range <= 0)
        {
            gettingBigger = true;
        }
        if (!gettingBigger)
        {
            lamp.range -= 4f * Time.deltaTime;
        }
    }
}
