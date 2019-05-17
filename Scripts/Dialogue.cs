using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index = 0;
    public float typingSpeed;
    private bool talk = true;
    private bool talk2 = true;
    public GameObject continueButton;
    private int textnmb;
    private int dlength = 2;
    bool nextSent = false;
    private bool talk3 = true;
    bool hebLadder = true;

    PlayerController playerScript;

    void Start()
    {
        // StartCoroutine(Type());
    }

    void Update()
    {
        playerScript = GameObject.Find("player").GetComponent<PlayerController>();
        textnmb = playerScript.getTextnmb();
        if (playerScript.getHaveLadder())
        {
            hebLadder = false;
        }
        if (textnmb == 1 && talk) {
            index = 0;
            dlength = 2;
            sentences[0] = "Andre Kuipers: “I’m badly hurt can you please find something to help me?”             PRESS SPACE";
            sentences[1] = "Wim Pjotter: “Of course.”             PRESS SPACE";
            StartCoroutine(Type());
            talk = false;
        }
        //Debug.Log(nextSent);
        if (textnmb == 2 && talk2) {
            Debug.Log("starrt");
            index = 0;
            dlength = 3;
            sentences[0] = "Andre: Thank you so much.             PRESS SPACE";
            sentences[1] = "Andre: I know a code that might come in handy later.             PRESS SPACE";
            sentences[2] = "Andre: It's 1734             PRESS SPACE";
            StartCoroutine(Type());
            talk2 = false;
        }
        if (textnmb == 3 && talk3 && hebLadder)
        {
            Debug.Log("reeee");
            index = 0;
            dlength = 2;
            sentences[0] = "Mark: Oops, there is a gap here.             PRESS SPACE";
            sentences[1] = "Mark: We need to find something to cross the gap             PRESS SPACE";
            StartCoroutine(Type());
            talk3 = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && nextSent) {
            if (playerScript.getTextnmb() > 0) {
                nextSent = false;
                NextSentence();
            }
        }
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray()) {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
            if (textDisplay.text.Length == sentences[index].Length) {
                nextSent = true;
            }
            }
        
    }

    public void NextSentence()
    {

        if (index < dlength - 1) {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else {
            textDisplay.text = "";
        }
    }
}