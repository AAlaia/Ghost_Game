using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class RoomSpawner : MonoBehaviour
    {
        Player player; 
        void Start()
        {
            if (GlobalControl.Instance.savedPlayerData.respawnAfterPhoto)
            {
                player = FindObjectOfType<Player>(); 
                player.transform.position = transform.position; 
            }
        }

        
    }   
}

