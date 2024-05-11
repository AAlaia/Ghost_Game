using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class MonsterDamage : MonoBehaviour
    {
        Health player; 
        public Animator animator; 
        void Start()
        {

        }

        void OnCollisionEnter2D(Collision2D other)
        {
            player = other.gameObject.GetComponent<Health>(); 
            if (player != null)
            {
                player.health -= 10; 
            }
            animator.Play("monsterBite"); 

        }

        void OnCollisionExit2D(Collision2D other)
        {
            animator.Play("idleMonster");
        }
    }

}
