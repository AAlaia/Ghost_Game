using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text timerText; 
    [SerializeField] float remainingTime;

    // Update is called once per frame
    void Update()
    {
        remainingTime -= Time.deltaTime; 
        int minutes = Mathf.FloorToInt(remainingTime / 60); 
        int seconds = Mathf.FloorToInt(remainingTime % 60); 
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); 
    }
}