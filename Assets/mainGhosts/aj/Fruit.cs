using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class Fruit : MonoBehaviour
    {

        void OnTriggerEnter2D(Collider2D other)
        {
            GlobalControl.Instance.savedPlayerData.fruitCollection++; 
            Destroy(gameObject); 
        }
        
    }
}

