using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackManager : MonoBehaviour
{
    public Transform playerPosition;
    public GameObject[] maps = new GameObject[2];
    private int numSpawnedMap;

    void Start()
    {
        numSpawnedMap = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerPosition.position.z >= 36.1f * (numSpawnedMap - 1))
        {
            Vector3 nextSpawn = new Vector3(-3.118387f, 5.410247f, 45.1f * numSpawnedMap);
            Instantiate(maps[Random.Range(0, 2)], nextSpawn, transform.rotation);
            numSpawnedMap++;
            //Destroy(gameObject);
        }
        
    }
    
}
