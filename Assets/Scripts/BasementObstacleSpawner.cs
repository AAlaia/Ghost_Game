using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class BasementObstacleSpawner : MonoBehaviour
    {
        public GameObject obstaclePrefab; 
        public GameObject obstacleGhost; 
        public float timer; 

        void Start()
        {
            timer = Random.Range(1f,2f); 
        }

        void Update()
        {
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                int changer = Random.Range(0, 2); 
                if (changer == 0)
                {
                    SpawnObstacle();
                }
                else
                {
                    SpawnGhost(); 
                }
                timer = Random.Range(3.0f, 6.0f);
            }
        }

        void SpawnObstacle()
        {
            Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
        }
        
        void SpawnGhost()
        {
            Instantiate(obstacleGhost, transform.position, Quaternion.identity); 
        }

    }


}
