using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageSpawner2 : MonoBehaviour
{

    public GameObject[] Garbage;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;

    public int randGarbage;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Spawner()); 
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }

    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(startWait);

        while (true)
        {
            randGarbage = Random.Range(0, 2);

            Vector3 spawnLocation = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 49, (float)0);

            Instantiate(Garbage[randGarbage], spawnLocation + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds (spawnWait);
        }
    }
}
