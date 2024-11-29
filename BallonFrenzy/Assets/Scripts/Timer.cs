using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText; // Timer
    [SerializeField] float remainingTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        remainingTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingTime / 60); // Minutes
        int seconds = Mathf.FloorToInt(remainingTime % 60); // Seconds
        timerText.text = string.Format("Time Survived:" + "{0:00}:{1:00}", minutes, seconds);
    }
}
