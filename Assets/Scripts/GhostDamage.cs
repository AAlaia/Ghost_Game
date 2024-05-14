using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class GhostDamage : MonoBehaviour
    {   
        Health player; 

        void OnTriggerEnter2D(Collider2D other)
        {
           player = other.gameObject.GetComponent<Health>(); 
           player.health -= 10; 

        }
 
    }

}
