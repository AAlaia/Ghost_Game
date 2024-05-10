using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timerText; 
    [SerializeField] public float remainingTime;

    // Update is called once per frame
    void Update()
    {
        remainingTime -= Time.deltaTime; 
        int minutes = Mathf.FloorToInt(remainingTime / 60); 
        int seconds = Mathf.FloorToInt(remainingTime % 60); 
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); 
    }
}
