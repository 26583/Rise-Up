using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rtspeed;
    public int speed = 4;
    private bool medKit = false;
    private bool lockers = false;
    private bool card = false;
    private bool card2 = false;
    private bool hurtWalks = false;
    private bool actie = false;
    private bool hurtBoy = false;
    private bool gap = false;
    private bool ladder = false;
    private int dialognumb = 0;
    private bool haveLadder = false;
    private bool dropLadder = false;
    private bool ladderDrop = false;
    private bool ladderPickable = true;
    private bool atspaceshuttle = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        actie = false;
        if (Input.GetKey(KeyCode.W)) {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(Vector3.down, rtspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(Vector3.up, rtspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E)) {
            if (lockers) {
                medKit = true;
                lockers = false;
                Debug.Log("yes");
            }
            if (hurtBoy) {
                medKit = false;
                hurtBoy = false;
                hurtWalks = true;
                dialognumb = 2;
            }
            if (ladder && ladderPickable) {
                haveLadder = true;
                ladder = false;
                ladderPickable = false;
            }
            if(haveLadder && dropLadder) {
                ladderDrop = true;
                dropLadder = false;
                haveLadder = false;
                ladderPickable = false;
            }
        }
        //transform.rotation = Quaternion.Euler(0, r, 0);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "card2") {
            Destroy(other.gameObject);
            card2 = true;
        }
        if (other.gameObject.name == "ladder" && ladderPickable) {
   
            ladder = true;
        }
        if (other.gameObject.name == "PutLadderDown" && haveLadder) {
            dropLadder = true;
        }
        if (other.gameObject.name == "card") {
            Destroy(other.gameObject);
            card = true;
        }
        if (other.gameObject.name == "Lockers" && !medKit) {
            lockers = true;
            Debug.Log("Medkit opgepakt");
        }
        if (other.gameObject.name == "Hurtboy" && medKit) {
            hurtBoy = true;
            //dialognumb = 2;
        }
        if (other.gameObject.name == "Hurtboy" && !medKit) {
            dialognumb = 1;
            Debug.Log(dialognumb);
        }
        if(other.gameObject.name == "gap")
        {
            dialognumb = 3;
        }
        if(other.gameObject.name == "EscapePod")
        {
            atspaceshuttle = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Lockers") {
            lockers = false;
            Debug.Log("Medkit opgepakt");
        }

        if (other.gameObject.name == "ladder") {
            ladder = false;
            Debug.Log("Medkit opgepakt");
        }
        if (other.gameObject.name == "Hurtboy" && medKit) {
            hurtBoy = false;
        }
        if (other.gameObject.name == "PutLadderDown") {
            dropLadder = false;
        }
        if (other.gameObject.name == "EscapePod")
        {
            atspaceshuttle = false;
        }
    }
    public bool getCardBool()
    {
        return card;
    }
    public bool getCard2Bool()
    {
        return card2;
    }
    public bool getLocker()
    {
        return lockers;
    }
    public bool getMed()
    {
        return medKit;
    }
    public bool getHurtBoy()
    {
        return hurtBoy;
    }
    public bool getGap()
    {
        return gap;
    }
    public bool getHurtWalks()
    {
        return hurtWalks;
    }
    public bool getHaveLadder()
    {
        return haveLadder;
    }
    public int getTextnmb()
    {
        return dialognumb;
    }
    public bool getDropZone()
    {
        return dropLadder;
    }
    public bool getLadderDrop()
    {
        return ladderDrop;
    }
    public bool getLadder()
    {
        return ladder;
    }
}
