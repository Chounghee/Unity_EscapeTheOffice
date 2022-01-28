using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDestroy : MonoBehaviour
{
    public float time = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, time);
    }
    
}
