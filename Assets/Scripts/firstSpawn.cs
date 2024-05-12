using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class firstSpawn : MonoBehaviour
    {
        Player player; 
        void Start()
        {
            if (GlobalControl.Instance.savedPlayerData.respawnAfterPhoto == true)
            {
                player = FindObjectOfType<Player>();
                player.transform.position = transform.position;  
            }
        }
    }
}

