using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemLadder : MonoBehaviour
{
    PlayerController playerScr;
    public Image ObjectwithImage;
    public Sprite ladder;
    public Sprite ladderframe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerScr = GameObject.Find("player").GetComponent<PlayerController>();
        if (playerScr.getHaveLadder())
        {
            ObjectwithImage.sprite = ladder;
        }
        if (!playerScr.getHaveLadder())
        {
            ObjectwithImage.sprite = ladderframe;
        }
    }
}
