using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerPosition;
    public GameObject[] maps = new GameObject[4];
    private int numSpawnedMap;

    void Start()
    {
        numSpawnedMap = 4;
    }
    void Update()
    {
        if (playerPosition.position.z >= 6.1f * (numSpawnedMap - 3))
        {
            Vector3 nextSpawn = new Vector3(0, 0, 6.1f * numSpawnedMap);
            Instantiate(maps[Random.Range(0, 4)], nextSpawn, transform.rotation);
            numSpawnedMap++;
            //Destroy(gameObject);
        }
    }
}


