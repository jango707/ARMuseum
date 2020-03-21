using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject visitor;
    public Transform spawnPoint;

    Vector3 randSpawn;

    public float StartTBS;
    private float timeBtwSpawns;

    private void Start()
    {
        
        timeBtwSpawns = StartTBS;
        
 
    }

    private void Update()
    {
        randSpawn.x = Random.Range(-5, 5);
        randSpawn.y = Random.Range(-5, 5);

        if (timeBtwSpawns <= 0)
        {
            Instantiate(visitor, spawnPoint.transform.position + randSpawn, Quaternion.identity);
            timeBtwSpawns = StartTBS;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
