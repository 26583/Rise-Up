using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayer : MonoBehaviour
{
    float time = 3.4f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time -= 1 * Time.deltaTime;
        if(time <= 0) {
            Application.LoadLevel("SampleScene");
        }
    }

}
