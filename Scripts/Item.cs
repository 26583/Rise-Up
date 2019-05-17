using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    PlayerController playerScr;
    public Image ObjectwithImage;
    public Sprite med;
    public Sprite frame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerScr = GameObject.Find("player").GetComponent<PlayerController>();
        if (playerScr.getMed()) {
            ObjectwithImage.sprite = med;
        }
        if (!playerScr.getMed()) {
            ObjectwithImage.sprite = frame;
        }
    }
}
