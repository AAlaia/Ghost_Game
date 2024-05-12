using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class Fruit : MonoBehaviour
    {
        void Update()
        {
            if (GlobalControl.Instance.savedPlayerData.stopSpawningFruit)
            {
                Destroy(gameObject); 
            }
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            GlobalControl.Instance.savedPlayerData.fruitCollection++; 
            Destroy(gameObject); 
        }
        
    }
}

