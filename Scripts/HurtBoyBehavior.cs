using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtBoyBehavior : MonoBehaviour
{
    PlayerController playerScr;
    private bool yes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerScr = GameObject.Find("player").GetComponent<PlayerController>();
        yes = playerScr.getHurtWalks();
        if(transform.position.z >= 4) {
            yes = false;
        }
        if (yes) {
            //transform.position += transform.forward * 3 * Time.deltaTime;
        }
    }
}
