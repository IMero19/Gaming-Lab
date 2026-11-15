using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            FindObjectOfType<PlayerStats>().score++;
            FindObjectOfType<PlayerStats>().scoreUI.text = " " + FindObjectOfType<PlayerStats>().score;
            Destroy(this.gameObject);
            Debug.Log(FindObjectOfType<PlayerStats>().score);
        }
    }
}
