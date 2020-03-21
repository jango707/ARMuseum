using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Transform[] target= new Transform[6];
    private float speed;

    private int current;

    private bool scoreCheck;

    Vector3 randSpawn;

    private void Start()
    {
        speed =   Random.Range(6.0f, 11.0f);
        target[0] = GameObject.Find("tagret").transform;
        target[1] = GameObject.Find("tagret (5)").transform;
        target[2] = GameObject.Find("tagret (1)").transform;
        target[3] = GameObject.Find("tagret (2)").transform;
        target[4] = GameObject.Find("tagret (3)").transform;
        target[5] = GameObject.Find("tagret (4)").transform;
        scoreCheck = false;
        GetComponent<SpriteRenderer>().color  = new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f)); ;
    }
    void Update()
    {
        
        //randSpawn.x = Random.Range(-5, 5);
        //randSpawn.y = Random.Range(-5, 5);




        if (transform.position == target[5].position)
        {
            Destroy(gameObject);
        }
        if (transform.position == target[0].position && scoreCheck == false)
        {
            scorer.score += 10;
            scoreCheck = true;
            
        }
        if (transform.position != target[current].position )
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed* Time.deltaTime);
            GetComponent<Rigidbody2D>().MovePosition(pos);

        } else current = (current + 1) % target.Length;

       
    }
}
