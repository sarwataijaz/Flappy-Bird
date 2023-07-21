using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float pipeSpeed = 5;
    public float deathZone = -45; // depending upon the speed of bird around x-axis
   
    // move pipe or move screen
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // to make sure the speed remains the same in every pc
        transform.position = transform.position + (Vector3.left * pipeSpeed) * Time.deltaTime;

        // for removing the remaining pipes
        if (transform.position.x < deathZone)
        {
            Debug.Log("Pipe Deleted!");
            Destroy(gameObject);
        }
    }
}
