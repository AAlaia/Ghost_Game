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
                int index = Random.Range(0, 4);
                Vector2 randomSpawnPos = new Vector2(Random.Range(-12.74f, 8.93f), Random.Range(-51.79f, -58.3f)); 
                Instantiate(fruits[index], randomSpawnPos, Quaternion.identity); 
                timer = Random.Range(0f, 2f);
            }
            if (endTimer.remainingTime <= 0)
            {
                GlobalControl.Instance.savedPlayerData.stopSpawningFruit = true; 
                endTimer.timerText.text = ""; 
                ending.finishedGame = true;
                Destroy(gameObject); 
            }
        }

    }

}
