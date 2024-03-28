using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    public GameObject objectToDestroy; 

    void Start()
    {
        if (objectToDestroy != null)
        {
            Destroy(objectToDestroy);
        }
    }

// Update is called once per frame
    void Update()
    {
        
    }
}
