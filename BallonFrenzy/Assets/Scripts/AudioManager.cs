using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiomanager : MonoBehaviour
{
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

}
