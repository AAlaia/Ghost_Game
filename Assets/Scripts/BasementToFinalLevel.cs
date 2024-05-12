using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace GhostGame
{
    public class BasementToFinalLevel : MonoBehaviour
    {
        [SerializeField] private Text interactableName;
        [SerializeField] private string itemNeeded;
        [SerializeField] private AudioSource doorOpen; 
        private string interactionText = "Interact [E]";

        private bool isOpened = false;

        private bool foundItem = false; 

        private bool objectAlreadyFound = false; 

        InvManager mgr; 

        void Start()
        {
            mgr = FindObjectOfType<InvManager>(); 
        }
        void Update()
        {
            if (isOpened)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    SceneManager.LoadScene(2); 
                    doorOpen.enabled = true; 
                }
            }
        }
        void OnTriggerEnter2D(Collider2D other)
        { 
            interactableName.text = interactionText;
            searchForItem(); 
            if (foundItem)
            {
                isOpened = true; 
                objectAlreadyFound = true;
            }
            else
            {
                gameObject.GetComponent<DialogueActiviation>().ActivateDialogue(); 
                interactableName.text = "Interact [E]"; 
            
            }
            GlobalControl.Instance.savedPlayerData.position = transform.position; 
    }
    
        void OnTriggerExit2D(Collider2D other)
        {
            interactableName.text = null;
            isOpened = false;
        }

        private void searchForItem()
        {
            if (!objectAlreadyFound)
            {
                foreach (Items i in mgr.items)
                {
                    if (string.Equals(i.name, itemNeeded))
                    {
                        foundItem = true; 
                    }
                }

            }
            else
            {
                interactableName.text = "Interact [E]";
            }

        }
    }

}
