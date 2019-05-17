using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScriptX : MonoBehaviour
{
    public float start;
    private bool open = false;
    public float end;
    private float timer = 3;
    public bool x = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (open) {
            Debug.Log("open1");
            if (transform.position.x >= end) {
                Debug.Log("open");
                transform.position += transform.right * 5 * Time.deltaTime;
            }

        }
        if (!open) {
            timer -= Time.deltaTime;

            if (transform.position.x <= start && timer < 0) {
                transform.position -= transform.right * 5 * Time.deltaTime;
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player" || other.gameObject.name == "friend") {
            open = true;
            Debug.Log("hoi");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "friend") {
            open = false;
        }
    }
}
