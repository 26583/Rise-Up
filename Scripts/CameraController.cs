using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera cOne;
    public Camera cTwo;
    private bool cameraOne =true;
    // Start is called before the first frame update
    void Start()
    {
        cOne.GetComponent<Camera>().enabled = true;
        cTwo.GetComponent<Camera>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            cameraOne = !cameraOne;
        }
        if (cameraOne) {
            cOne.GetComponent<Camera>().enabled = true;
            cTwo.GetComponent<Camera>().enabled = false;
        }
        if (!cameraOne) {
            cOne.GetComponent<Camera>().enabled = false;
            cTwo.GetComponent<Camera>().enabled = true;
        }
    }
}
