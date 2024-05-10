using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class FruitSpawner : MonoBehaviour
    {

        public GameObject[] fruits; 
        public float timer; 
        ajInteraction ending; 
        Timer endTimer;

        void Start()
        {
            ending = FindObjectOfType<ajInteraction>(); 
            timer = Random.Range(1f,2f); 
        }

        void Update()
        {
            timer -= Time.deltaTime;
            endTimer = gameObject.GetComponent<Timer>(); 
            if (timer <= 0f)
            {
                int index = Random.Range(0, 3);
                Vector2 randomSpawnPos = new Vector2(Random.Range(-10.84f, 10.8f), Random.Range(1.12f, -5.27f)); 
                Instantiate(fruits[index], randomSpawnPos, Quaternion.identity); 
                timer = Random.Range(1f, 3f);
            }
            if (endTimer.remainingTime <= 0)
            {
                endTimer.timerText.text = ""; 
                ending.finishedGame = true; 
                Destroy(gameObject); 
            }
        }

    }

}
