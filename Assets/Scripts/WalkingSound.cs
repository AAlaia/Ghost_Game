using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class WalkingSound : MonoBehaviour
    {
        public AudioSource footstepsSound; 

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
            {
                footstepsSound.enabled = true;
            }
            else
            {
                footstepsSound.enabled = false; 
            }
        }
    }   
}

