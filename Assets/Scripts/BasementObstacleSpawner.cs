using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class BasementObstacleSpawner : MonoBehaviour
    {
         public GameObject[] obstacles; 
        public float timer; 

        void Start()
        {
            timer = Random.Range(0f,1f); 
        }

        void Update()
        {
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                int index = Random.Range(0, 4); 
                Instantiate(obstacles[index], transform.position, Quaternion.identity); 
                timer = Random.Range(0f, 2f); 
            }
        }

    }


}
