using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageSpawner : MonoBehaviour
{

    public GameObject Garbage1;
    public GameObject Garbage2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // When the cannonball is created it will set its velocity
            // that is outwards from the cannon
            GameObject NewGarbage1 = Instantiate(Garbage1);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            // When the cannonball is created it will set its velocity
            // that is outwards from the cannon
            GameObject NewGarbage2 = Instantiate(Garbage2);
        }
    }
}
