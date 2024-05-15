using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class GhostDamage : MonoBehaviour
    {   

        void OnTriggerEnter2D(Collider2D other)
        {
           GlobalControl.Instance.savedPlayerData.health -= 10; 

        }
 
    }

}
