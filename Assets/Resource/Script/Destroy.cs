using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{    
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 view = Camera.main.WorldToScreenPoint(transform.position);
        if (view.z > -16)
        {
            Destroy(gameObject);
        }
    }
}
