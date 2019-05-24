using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemKey : MonoBehaviour
{
    PlayerController playerScr;
    public Image ObjectwithImage1;
    public Image ObjectwithImage2;
    public Sprite key;
    public Sprite frame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerScr = GameObject.Find("player").GetComponent<PlayerController>();
        if (playerScr.haveKey())
        {
            ObjectwithImage1.sprite = key;
        }
        if (!playerScr.haveKey())
        {
            ObjectwithImage1.sprite = frame;
        }
        if (playerScr.haveKey2())
        {
            ObjectwithImage2.sprite = key;
        }
        if (!playerScr.haveKey2())
        {
            ObjectwithImage2.sprite = frame;
        }
    }
}
