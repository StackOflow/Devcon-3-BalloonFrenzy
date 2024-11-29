using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GarbageSpawner : MonoBehaviour
{

    public GameObject Garbage1;
    public GameObject Garbage2;

    public GameObject[] myObjects;
    public float spawnInterval = 0.2f; // time before next spawn
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            StartCoroutine(Wait()); // Once the timer hits 0, instantiate an object
            timer = 0f;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            // When the cannonball is created it will set its velocity
            // that is outwards from the cannon
            GameObject NewGarbage1 = Instantiate(Garbage1);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {

            GameObject NewGarbage2 = Instantiate(Garbage2);
        }
    }
    private IEnumerator Wait()
    {
        int randomIndex = UnityEngine.Random.Range(0, myObjects.Length);
        Vector3 randomSpawnPosition = new Vector3(UnityEngine.Random.Range(-1, 1), 70, UnityEngine.Random.Range(-1, 1));

        Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
        yield return null;
    }

}
