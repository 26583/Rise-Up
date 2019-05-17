using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendAi : MonoBehaviour
{
    public GameObject player;
    private bool closeToP = false;
    public Transform target;
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        if (!closeToP) {
            transform.position += transform.forward * speed * Time.deltaTime;
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player") {
            closeToP = true;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "player") {
            closeToP = false;
        }
    }

}
