using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float r = -90;
    public int speed = 3;
    private bool card = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)) {
            r -= 1.3f;
        }
        if (Input.GetKey(KeyCode.D)) {
            r += 1.3f;
        }
        transform.rotation = Quaternion.Euler(0, r, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "card") {
            Destroy(other.gameObject);
            card = true;
        }
    }

    public bool getCardBool()
    {
        return card;
    }
}
