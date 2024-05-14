using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class SpawnPlayer : MonoBehaviour
    {
        [SerializeField] Player player; 
        void Awake()
        {
            player.transform.position = transform.position; 
        }

    
    }

}
