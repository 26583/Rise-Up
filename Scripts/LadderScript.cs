using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderScript : MonoBehaviour
{
    PlayerController playerScr;
    public Vector3 pickedUp;
    public Vector3 putDown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerScr = GameObject.Find("player").GetComponent<PlayerController>();
        if (playerScr.getHaveLadder()) {
            transform.position = pickedUp;
        }
        if (playerScr.getLadderDrop()) {
            transform.position = putDown;
        }
    }
}
