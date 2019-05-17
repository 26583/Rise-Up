using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PickUp : MonoBehaviour
{
    PlayerController playerScr;
    public TextMeshProUGUI pickUpText;
    bool med = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        med = false;
        playerScr = GameObject.Find("player").GetComponent<PlayerController>();
        if (playerScr.getLocker()) {
            pickUpText.text = "Press 'E' to pick up Medkit";
        }
        if (playerScr.getLadder() && !playerScr.getHaveLadder()) {
            pickUpText.text = "Press 'E' to pick up ladder";
        }

        if (playerScr.getDropZone()) {
            pickUpText.text = "Press 'E' to put down the ladder";

        }
        /*if (!playerScr.getLocker()) {
            pickUpText.text = "";
        }*/
        
        if (playerScr.getMed() && playerScr.getHurtBoy()) {
            pickUpText.text = "Press 'E' to use Medkit";
            Debug.Log("Med");
            med = true;
        }
        if (!med && !playerScr.getLocker() && !playerScr.getDropZone() && !playerScr.getLadder()) {
            pickUpText.text = "";

        }
        
    }
}
