using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class MonsterDamage : MonoBehaviour
    {
        Health player; 

        void OnCollisionEnter2D(Collision2D other)
        {
            player = other.gameObject.GetComponent<Health>(); 
            if (player != null)
            {
                GlobalControl.Instance.savedPlayerData.health -= 30; 

            }
        }
    }

}
