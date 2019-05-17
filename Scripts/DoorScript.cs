using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private bool open = false;
    private bool close = false;
    private float timer = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (open) {
            transform.position -= new Vector3(0,5,0) * 4 * Time.deltaTime;
        }
        if(transform.position.y <= -1 && open) {
            //open = false;
        }
        if (close) {
            timer -= 1 * Time.deltaTime;
            if (timer <= 0) {
                transform.position += new Vector3(0, 4, 0) * 4 * Time.deltaTime;
            }
        }
        if(transform.position.y >= 1f && close) {
            close = false;
        }
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player"/* || other.gameObject.name == "friend"*/) {
            open = true;
            timer = 2;
            
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "player" /*other.gameObject.name == "friend"*/) {
            close = true;
            open = false;
        }
    }
}
