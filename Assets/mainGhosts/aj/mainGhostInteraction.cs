using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GhostGame
{
    public class mainGhostInteraction : MonoBehaviour
    {
        private bool isInteract = false;
        [SerializeField] Text text; 

        void Update()
        {
            if (isInteract)
            {
                text.text = "Interact [E]"; 
                if(Input.GetKeyDown(KeyCode.E))
                {
                    gameObject.GetComponent<GhostObjective>().ActivateGhostDialogue(); 
                }
            }
            else
            {
                text.text = "";
            }
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            isInteract = true; 
        }

        void OnTriggerExit2D(Collider2D other)
        {
            isInteract = false; 
        }
    
    }

}

