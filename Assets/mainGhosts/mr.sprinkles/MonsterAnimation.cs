using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class MonsterAnimation : MonoBehaviour
    {
        public Animator animator;

        void OnTriggerEnter2D(Collider2D other)
        {
            animator.SetBool("OnContact", true); 
        }

        void OnTriggerExit2D(Collider2D other)
        {
            animator.SetBool("OnContact", false); 
        }
    }

}
