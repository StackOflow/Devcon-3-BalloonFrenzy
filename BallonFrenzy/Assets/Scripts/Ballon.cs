using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ballon : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("POP"))
        {
            source.PlayOneShot(clip);
            StartCoroutine(Wait());
            Destroy(gameObject);
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }


}
