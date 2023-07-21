using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class SpawnPipeScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnTime = 2;
    public float height = 10; 
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        // start spawning shuru me hi

        spawnHeight();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnTime)
        {
            timer = timer + Time.deltaTime;
        }

        else
        {
            spawnHeight();
            timer = 0;
        }
    }

     void spawnHeight()
    {

        float lowest = transform.position.y - height;
        float highest = transform.position.y + height;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowest, highest), 0), transform.rotation);
    }
}
