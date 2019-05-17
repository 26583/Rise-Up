using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadScript : MonoBehaviour
{
    public GameObject panel;
    public Text code;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(code.text);
        if(code.text == "1734" && Input.GetKey(KeyCode.Return)) {
            panel.SetActive(false);
            Application.LoadLevel("End");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "EscapePod") {
            panel.SetActive(true);
            
        }
    }
}
