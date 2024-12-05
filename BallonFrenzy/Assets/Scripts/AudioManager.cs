using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audiomanager : MonoBehaviour
{
    public static bool isPop = false;
    [Header("-------- Audio Source --------")]
    [SerializeField] AudioSource MusicSource;

    [Header("-------- Audio Clip --------")]
    public AudioClip Background;
    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip = Background;
        MusicSource.Play();
    }

    private void Update()
    {
        if (isPop)
        {
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2f);
        isPop = false;
        SceneManager.LoadScene(2); // Load Losing Scene
    }

}
