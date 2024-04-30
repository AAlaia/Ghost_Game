using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class playerH : MonoBehaviour
    {
        public int playerHealth; 

        void Start()
        {
            playerHealth = GlobalControl.Instance.savedPlayerData.health;  
        }

        void takeDamage(int damage)
        {
            playerHealth -= damage; 
            GlobalControl.Instance.savedPlayerData.health = playerHealth;
        }

        public int getHealth()
        {
            // playerH objectHealth = GetComponent<playerH>();
            return playerHealth; 
        }

        /*public void tryDamage(GameObject target, int damage)
        {
            Health otherHealth = target.GetComponent<Health>();
            playerH health = this.playerH; 
            if (otherHealth)    
            {
                health.takeDamage(damage);
            }
        } */



    }
}