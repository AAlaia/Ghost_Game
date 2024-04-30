using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class Health : MonoBehaviour
    {
        public int health; 

        void Start()
        {
            health = GlobalControl.Instance.savedPlayerData.health;
        }

        void takeDamage(int damage)
        {
            health -= damage;
            GlobalControl.Instance.savedPlayerData.health = health;
        }

        public int getHealth()
        {
            Health objectHealth = GetComponent<Health>();
            return objectHealth.health;
        }

        public void tryDamage(GameObject target, int damage)
        {
            Health otherHealth = target.GetComponent<Health>();
            if (otherHealth)    
            {
                otherHealth.takeDamage(damage);
            }
        }


    }
}

