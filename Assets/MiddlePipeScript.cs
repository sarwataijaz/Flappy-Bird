using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MiddlePipeScript : MonoBehaviour
{

    public LogicScript logic; // for framing it with logic script so we KNOW when to increase score
    // Start is called before the first frame update
    void Start()
    {
        // its the same thing as dragging a component into our gameobject so whenever it will
        // encounter a new spawning, it willl automatically be notified
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 3)
        {
            Debug.Log("Collision occured.");
            logic.addScore(1);
        }
    }
}
