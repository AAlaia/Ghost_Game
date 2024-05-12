using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

namespace GhostGame
{
    public class InitiatePhoto : MonoBehaviour
    {
        private bool beginObjective = false; 
        private bool IsInteract = false;
        [SerializeField] Text text; 

        void Update()
        {
            if (IsInteract)
            {
                text.text = "Interact[E]"; 
                if (beginObjective)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene("FamilyPortraitPuzzle"); 
                    }
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
            beginObjective = true; 
        }
        void OnTriggerExit2D(Collider2D other)
        {
            beginObjective = false; 
            IsInteract = false; 
        }
    }
}
