using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // sprite renderer is used for displaying game characeters like bird in our case.
    // rigid body 2D for gravity purpose
    // circle collider for collisions with pipes

    public Rigidbody2D myRigidBody;

    // adding a public variable so we can directly change speed in unity

    public float birdStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;


    // Start is called before the first frame update
    void Start()

    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        // Reading user input
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidBody.velocity = Vector2.up * birdStrength; // another way of saying (0,1) in vector form as it will send the birf to fly upwards
        }

        if(transform.position.y < -50)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }

   private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    } 
}
