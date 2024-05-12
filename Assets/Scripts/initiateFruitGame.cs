using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

namespace GhostGame
{
    public class initiateFruitGame : MonoBehaviour
    {
        private bool IsInteract = false;
        [SerializeField] Text text; 
        [SerializeField] GameObject fruitGame;  

        void Update()
        {
            if (IsInteract)
            {
                text.text = "Interact[E]"; 
                if (Input.GetKeyDown(KeyCode.E))
                {
                    fruitGame.SetActive(true); 
                    gameObject.SetActive(false);  
                }
            }
            else
            {
                text.text = ""; 
            }

        }

        void OnTriggerEnter2D(Collider2D other)
        {
            IsInteract = true; 
        }
        void OnTriggerExit2D(Collider2D other)
        {
            IsInteract = false; 
        }
    }
}

