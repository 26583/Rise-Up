using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehavior : MonoBehaviour
{
    PlayerController playerScr;
    private bool trigger = false;
    public bool door1 = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        playerScr = GameObject.Find("player").GetComponent<PlayerController>();
        if (trigger) {
            transform.position -= transform.up * 2 * Time.deltaTime;
        }
        if(transform.position.y <= -3) {
            trigger = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player"&& playerScr.getCardBool() && door1) {
            trigger = true;
        }
        if (other.gameObject.name == "player" && playerScr.getCard2Bool() && !door1) {
            trigger = true;
        }
    }
}
